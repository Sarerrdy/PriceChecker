
var Labels = [];
var Prices = [];
var Dates = [];
var productHistory = [];

var ProCatName = "select category";
var ProName = "select product";
var ChartLabel = ProName  + " in " + ProCatName;


const ctx = document.getElementById('myChart');
const myChart = new Chart(ctx, {
    type: 'bar',
    data: {
        labels: Labels,
        datasets: [{
            label: "",
            data: Prices,
            backgroundColor: [
                'rgb(255, 99, 132)',
                'rgba(45, 20, 100)',
                'rgba(54, 162, 235)',
                'rgba(255, 206, 86)',
                'rgba(75, 192, 192)',
                'rgba(153, 102, 255)',
                'rgba(104, 162, 5)',
                'rgba(205, 206, 186)',
                'rgba(75, 0, 0)',
                'rgba(153, 192, 55)'
            ],
            borderColor: [
                'rgb(255, 99, 132)',
                'rgba(255,99,132)',
                'rgba(54, 162, 235)',
                'rgba(255, 206, 86)',
                'rgba(75, 192, 192)',
                'rgba(153, 102, 255)',
                'rgba(255, 159, 64)',
                'rgba(75, 192, 212)',
                'rgba(153, 102, 200)',
                'rgba(255, 159, 4)'
            ],
            borderWidth: 1
        }]
    },
    options: {
        scales: {
            y: {
                beginAtZero: true
            }
        }
    }
});



const ctxPie = document.getElementById('myPieChart');
const myPieChart = new Chart(ctxPie, {
    type: 'pie',
    data: {
        labels: Labels,
        datasets: [{
            label: 'Product Pie Chart',
            data: Prices,
            backgroundColor: [
                'rgb(255, 99, 132)',
                'rgba(45, 20, 100)',
                'rgba(54, 162, 235)',
                'rgba(255, 206, 86)',
                'rgba(75, 192, 192)',
                'rgba(153, 102, 255)',
                'rgba(104, 162, 5)',
                'rgba(205, 206, 186)',
                'rgba(75, 0, 0)',
                'rgba(153, 192, 55)'
            ],
            borderColor: [
                'rgb(255, 99, 132)',
                'rgba(255,99,132)',
                'rgba(54, 162, 235)',
                'rgba(255, 206, 86)',
                'rgba(75, 192, 192)',
                'rgba(153, 102, 255)',
                'rgba(255, 159, 64)',
                'rgba(75, 192, 212)',
                'rgba(153, 102, 200)',
                'rgba(255, 159, 4)'
            ],
            borderWidth: 1
        }]
    }
});




function addData(chart, label, data, chartLabel) {
    chart.data.labels = label;
    chart.data.datasets.forEach((dataset) => {
        dataset.data = data;
        /*dataset.label = chartLabel;*/
    });
    chart.update();
}



function OnSearchBtnClick() {
    FetchProductHistoryApi()
}

function FetchProductHistoryApi() {
    var CategoryId = document.getElementById("SelectedCategory").value;
    var productId =document.getElementById("SelectedProduct").value;
   // var searchWord = document.getElementById("SearchTerm").value;

    var q = document.getElementById("SelectedProduct");
    ProCatName = q.options[q.selectedIndex].text;

    var e = document.getElementById("SelectedCategory");
    ProName = e.options[e.selectedIndex].text;

   // document.getElementById("locationWidget").innerHTML = ProCatName + " in " + ProName;



    var xhttp = new XMLHttpRequest();
    var uri = "/api/ChartsApi/LoadHistories" + "/" + productId + "/" + CategoryId
    xhttp.open("GET", uri, true);
    xhttp.setRequestHeader('Content-Type', 'application/json');
    xhttp.send();

    xhttp.onloadend = function () {
        if (this.readyState == 4 && this.status == 200) {
            var response = JSON.parse(this.responseText);
            productHistory = response.Histories;
            Labels = response.Dates;
            Prices = response.Prices;

           
            addData(myPieChart, Labels, Prices);
            addData(myChart, Labels, Prices, ChartLabel)


           generate_table();

        }
    }
}

function FetchProductSelectListApi() {
   
    var selectedCatId = $("#SelectedCategory").val();
    var selectedProduct = $('#SelectedProduct');

    //set textValue from selectedCategory
    let categoryName = $("#SelectedCategory option:selected").text()
    //$("#StateName").val(stateName)


    selectedProduct.empty();
    if (selectedCatId != null && selectedCatId != '' && selectedCatId != 'Select Category') {
        $.getJSON("/api/ChartsApi/LoadHistories" + "/" + selectedCatId,
            function (products) {
                if (products != null && !jQuery.isEmptyObject(products)) {
                    selectedProduct.append($('<option/>', {
                        value: null,
                        text: "Select " + categoryName + " product"
                    }));
                    $.each(products, function (index, products) {
                        selectedProduct.append($('<option/>', {
                            value: products.Value,
                            text: products.Text
                        }));
                    });
                }
                else {
                    selectedProduct.append($('<option/>', {
                        value: null,
                        text: categoryName + " products currently not available"
                    }));
                }
            });
    }
}


$(document).ready(function (e) {    

    FetchProductHistoryApi();

    $('#SelectedProduct').change(function () {
        var ProId = document.getElementById("SelectedProduct").value;
        if (ProId !== "0") {
            //generate_table();
            FetchProductHistoryApi();
        }

    });

    $('#SelectedCategory').change(function (e) {
        var ProCatId = document.getElementById("SelectedCategory").value;
        if (ProCatId !== "0") {
            FetchProductSelectListApi();
        }

    });

    $('#SearchTerm').keyup(function (e) {
        FetchProductHistoryApi();

    });
});


function generate_table() {

    //FetchApiData();
    // get the reference for the body
    // var body = document.getElementsByTagName("body")[0];


    var col = [];
    for (var i = 0; i < productHistory.length; i++) {

        for (var key in productHistory[i]) {
            if (col.indexOf(key) === -1) {
                col.push(key);
            }
        }
    }

    // creates a <tbody> element
    if (productHistory.length > 0) {
        $("#table_body").children().remove();
    }
    // var table = document.getElementById("product-table");
    var tbody = document.getElementById("table_body");
    var tr = tbody.insertRow(-1);

    /// Creat Header for the Table
    //for (var i = 0; i < col.length; i++) {
    //    var th = document.createElement("th");
    //    th.innerHTML = col[i];
    //    tr.appendChild(th);
    //}

    ///var tblBody = document.getElementById("table_body");

    // creating all cells
    for (var i = 0; i < productHistory.length; i++) {
        tr = tbody.insertRow(-1);

        for (var j = 0; j < col.length; j++) {

            var tabCell = tr.insertCell(-1);
            //var cell = row.insertCell(-1);
            //var addLinkToProduct = product[0];

            //if (j == 1) {
            //    var productId = product[i][col[0]];
            //    var prodUrl = '<img height="50" width="50" src="/images/Products/' + product[i][col[2]] + '"' + '/>';
            //    var addLinkToProduct = '<a style="color:blue" href=PriceHistory?productId=' + productId + '>' + product[i][col[1]] + '</a> ';
            //    product[i][col[1]] = addLinkToProduct;
            //    product[i][col[2]] = prodUrl;
            //}

            tabCell.innerHTML = productHistory[i][col[j]];
        }
    }
}
