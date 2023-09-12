using Microsoft.CodeAnalysis;
using PriceChecker.Models.Context;

namespace PriceChecker.Models
{
    public class PriceCheckerSeeder /*: IPriceCheckerSeeder*/
    {
        private readonly PriceCheckerContext _ctx;

        public PriceCheckerSeeder(PriceCheckerContext ctx)
        {
            _ctx = ctx;
        }

        /// <summary>
        /// Seed Country, State and LGA Data and sample model data for products
        /// </summary>
        /// <returns></returns>
        public async Task Seed()
        {
            _ctx.Database.EnsureCreated();

            ///Seed Country, states and LGA with data
            if (!_ctx.Countries.Any())
            {
                var country = new List<Country>()
                {
                    new Country
                    {
                        CountryName ="Nigeria",
                        States = new List<State>()
                        {
                            new State
                            {
                                StateName ="Abia",
                                LGAs = new List<LGA>()
                                {
                                    new LGA {LGAName="Aba North" },
                                    new LGA{LGAName="Aba South" },
                                    new LGA{LGAName="Arochukwu" },
                                    new LGA{LGAName="Bende" },
                                    new LGA{LGAName="Isiala Ngwa South" },
                                    new LGA{LGAName="Ikwuano" },
                                    new LGA{LGAName="Isiala"},
                                    new LGA{LGAName="Ngwa North" },
                                    new LGA{LGAName="Isukwuato"},
                                    new LGA{LGAName="Ukwa West"},
                                    new LGA{LGAName="Ukwa East,"},
                                    new LGA{LGAName="Umuahia"},
                                    new LGA{LGAName="Umuahia South"}
                                }

                            },

                            new State
                            {
                                StateName ="Adamawa",
                                LGAs = new List<LGA>()
                                {
                                    new LGA {LGAName="Demsa" },
                                    new LGA{LGAName="Fufore" },
                                    new LGA{LGAName="Ganye" },
                                    new LGA{LGAName="Girei" },
                                    new LGA{LGAName="Gombi" },
                                    new LGA{LGAName="Jeda" },
                                    new LGA{LGAName="Yola North"},
                                    new LGA{LGAName="Yola South" },
                                    new LGA{LGAName="Lamurde"},
                                    new LGA{LGAName="Madagali"},
                                    new LGA{LGAName="Maiha,"},
                                    new LGA{LGAName="Mayo-Belwa"},
                                    new LGA{LGAName="Michika"},
                                    new LGA{LGAName="Mubi South"},
                                    new LGA{LGAName="Numna"},
                                    new LGA{LGAName="Shelleng"},
                                    new LGA{LGAName="Song"},
                                    new LGA{LGAName="Toungo"},
                                     new LGA{LGAName="Hung"}
                                }

                            },

                            new State
                            {
                                StateName ="Anambra",
                                LGAs = new List<LGA>()
                                {
                                    new LGA {LGAName="Aguata" },
                                    new LGA{LGAName="Anambra" },
                                    new LGA{LGAName="Anambra West" },
                                    new LGA{LGAName="Anaocha" },
                                    new LGA{LGAName="Awka South" },
                                    new LGA{LGAName="Awka North" },
                                    new LGA{LGAName="Ogbaru"},
                                    new LGA{LGAName="Onitsha South" },
                                    new LGA{LGAName="Onitsha North"},
                                    new LGA{LGAName="Orumba North"},
                                    new LGA{LGAName="Orumba South,"},
                                    new LGA{LGAName="Oyi"},
                                    new LGA{LGAName="Michika"},
                                    new LGA{LGAName="Mubi South"},
                                    new LGA{LGAName="Numna"},
                                    new LGA{LGAName="Shelleng"},
                                    new LGA{LGAName="Song"},
                                    new LGA{LGAName="Toungo"},
                                     new LGA{LGAName="Hung"}
                                }
                            },

                            new State
                            {
                                StateName ="Akwa-Ibom",
                                LGAs = new List<LGA>()
                                {
                                    new LGA {LGAName="Abak" },
                                    new LGA{LGAName="eastern Obolo" },
                                    new LGA{LGAName="Eket" },
                                    new LGA{LGAName="Essien Udim" },
                                    new LGA{LGAName="Etimekpo" },
                                    new LGA{LGAName="Etinan" },
                                    new LGA{LGAName="Ibeno"},
                                    new LGA{LGAName="Ibesikpo Asutan" },
                                    new LGA{LGAName="Ibiono Ibom"},
                                    new LGA{LGAName="Ika"},
                                    new LGA{LGAName="Ikono"},
                                    new LGA{LGAName="Ikot Abasi"},
                                    new LGA{LGAName="Ikot Ekpene"},
                                    new LGA{LGAName="Inu"},
                                    new LGA{LGAName="Itu"},
                                    new LGA{LGAName="Mbo"},
                                    new LGA{LGAName="Mkpat Enin"},
                                    new LGA{LGAName="Nsit Ibom"},
                                    new LGA{LGAName="Nsit Ubium"},
                                    new LGA{LGAName="Obot Akara"},
                                    new LGA{LGAName="Okobo"},
                                    new LGA{LGAName="Onna"},
                                    new LGA{LGAName="Orukanam"},
                                    new LGA{LGAName="Oron"},
                                    new LGA{LGAName="Udung Uko"},
                                    new LGA{LGAName="Ukanafun"},
                                    new LGA{LGAName="Uruan"},
                                    new LGA{LGAName="Urue Offoung"},
                                    new LGA{LGAName="Oruko Ete"},
                                    new LGA{LGAName="Uyo"}
                                }
                            },

                            new State
                            {
                                StateName ="Bauchi",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Alkaleri" },
                                    new LGA{LGAName="Bauchi" },
                                    new LGA{LGAName="Bogoro" },
                                    new LGA{LGAName="Darazo" },
                                    new LGA{LGAName="Dass" },
                                    new LGA{LGAName="Gamawa" },
                                    new LGA{LGAName="Ganjuwa"},
                                    new LGA{LGAName="Giade" },
                                    new LGA{LGAName="Jama`are"},
                                    new LGA{LGAName="Katagum"},
                                    new LGA{LGAName="Kirfi,"},
                                    new LGA{LGAName="Misau"},
                                    new LGA{LGAName="Ningi"},
                                    new LGA{LGAName="Hira"},
                                    new LGA{LGAName="Tafawa Balewa"},
                                    new LGA{LGAName="Itas gadau"},
                                    new LGA{LGAName="Toro"},
                                    new LGA{LGAName="Warji"},
                                    new LGA{LGAName="Zaki"},
                                    new LGA{LGAName="Dambam"}
                                }

                            },

                            new State
                            {
                                StateName ="Bayelsa",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Brass" },
                                    new LGA{LGAName="Ekeremor" },
                                    new LGA{LGAName="Kolok" },
                                    new LGA{LGAName="Opokuma" },
                                    new LGA{LGAName="Nembe" },
                                    new LGA{LGAName="Ogbia" },
                                    new LGA{LGAName="Sagbama"},
                                    new LGA{LGAName="Southern Ijaw" },
                                    new LGA{LGAName="Yenagoa"},
                                    new LGA{LGAName="Membe"}
                                }

                            },

                            new State
                            {
                                StateName ="Benue",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Ador" },
                                    new LGA{LGAName="Agatu" },
                                    new LGA{LGAName="Apa" },
                                    new LGA{LGAName="Buruku" },
                                    new LGA{LGAName="Gboko" },
                                    new LGA{LGAName="Guma" },
                                    new LGA{LGAName="Gwer east"},
                                    new LGA{LGAName="Gwer west" },
                                    new LGA{LGAName="Kastina-ala"},
                                    new LGA{LGAName="Konshisha"},
                                    new LGA{LGAName="Kwande,"},
                                    new LGA{LGAName="Makurdii"},
                                    new LGA{LGAName="Logo"},
                                    new LGA{LGAName="Obi"},
                                    new LGA{LGAName="Ohimini"},
                                    new LGA{LGAName="Okpokwu"},
                                    new LGA{LGAName="Oju"},
                                    new LGA{LGAName="Oturkpo"},
                                    new LGA{LGAName="Tarka"},
                                    new LGA{LGAName="Ukum"},
                                    new LGA{LGAName="Vandekya"}
                                }
                            },

                            new State
                            {
                                StateName ="Borno",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Abadan" },
                                    new LGA{LGAName="Askira" },
                                    new LGA{LGAName="Uba" },
                                    new LGA{LGAName="Bama" },
                                    new LGA{LGAName="Bayo" },
                                    new LGA{LGAName="Biu" },
                                    new LGA{LGAName="Damboa"},
                                    new LGA{LGAName="Chibok" },
                                    new LGA{LGAName="Dikwagubio"},
                                    new LGA{LGAName="Guzamala"},
                                    new LGA{LGAName="Hawul"},
                                    new LGA{LGAName="Gwoza"},
                                    new LGA{LGAName="Jere"},
                                    new LGA{LGAName="Kaga"},
                                    new LGA{LGAName="Kalka, "},
                                    new LGA{LGAName="Balge"},
                                    new LGA{LGAName="Konduga"},
                                    new LGA{LGAName="Kukawa"},
                                    new LGA{LGAName="Kwaya-ku"},
                                    new LGA{LGAName="Mafa"},
                                    new LGA{LGAName="Magumeri"},
                                    new LGA{LGAName="Maiduguri"},
                                    new LGA{LGAName="Marte"},
                                    new LGA{LGAName="Mobbar"},
                                    new LGA{LGAName="Monguno"},
                                    new LGA{LGAName="Ngala"},
                                    new LGA{LGAName="Nganzai"},
                                     new LGA{LGAName="Shani"}
                                }
                            },

                            new State
                            {
                                StateName ="Cross River",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Abi" },
                                    new LGA{LGAName="Akampa" },
                                    new LGA{LGAName="Akpabuyo" },
                                    new LGA{LGAName="Bakassi" },
                                    new LGA{LGAName="Biase" },
                                    new LGA{LGAName="Boki" },
                                    new LGA{LGAName="Calabar south"},
                                    new LGA{LGAName="Calabar Municipal"},
                                     new LGA{LGAName="Etung"},
                                    new LGA{LGAName="Ikom" },
                                    new LGA{LGAName="Obanliku"},
                                    new LGA{LGAName="Obubra"},
                                    new LGA{LGAName="Obudu"},
                                    new LGA{LGAName="Odukpani"},
                                    new LGA{LGAName="Ogoja"},
                                    new LGA{LGAName="Yala"},
                                    new LGA{LGAName="Yarkurr, "},
                                    new LGA{LGAName="Bekwara"}
                                }
                            },

                            new State
                            {
                                StateName ="Delta",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Aniocha south" },
                                    new LGA{LGAName="Anioha" },
                                    new LGA{LGAName="Bomadi" },
                                    new LGA{LGAName="Ethiope west" },
                                    new LGA{LGAName="Ethiope east" },
                                    new LGA{LGAName="Ika south" },
                                    new LGA{LGAName="Ika north"},
                                    new LGA{LGAName="Isoko south" },
                                    new LGA{LGAName="Isoko north"},
                                    new LGA{LGAName="Ndokwa east"},
                                    new LGA{LGAName="Ndokwa west"},
                                    new LGA{LGAName="Okpe"},
                                    new LGA{LGAName="Oshimili north"},
                                    new LGA{LGAName="Oshimili south"},
                                    new LGA{LGAName="Patani, "},
                                    new LGA{LGAName="Sapele"},
                                    new LGA{LGAName="Udu"},
                                    new LGA{LGAName="Ughelli south"},
                                    new LGA{LGAName="Ughelli north"},
                                    new LGA{LGAName="Ukwuani"},
                                    new LGA{LGAName="Uviwie"},
                                    new LGA{LGAName="Warri central"},
                                    new LGA{LGAName="Warri north"},
                                    new LGA{LGAName="Warri south"}
                                }
                            },

                             new State
                            {
                                StateName ="Ebonyi ",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Abakaliki" },
                                    new LGA{LGAName="Afikpo south" },
                                    new LGA{LGAName="Afikpo north" },
                                    new LGA{LGAName="Ebonyi" },
                                    new LGA{LGAName="Ezza" },
                                    new LGA{LGAName="Ezza south" },
                                    new LGA{LGAName="Ikwo"},
                                    new LGA{LGAName="Ishielu" },
                                    new LGA{LGAName="Ivo"},
                                    new LGA{LGAName="Ohaozara"},
                                    new LGA{LGAName="Ohaukwu"},
                                    new LGA{LGAName="Onicha"},
                                    new LGA{LGAName="Izzi"}
                                }
                            },

                            new State
                            {
                                StateName ="Edo",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Akoko-Edo" },
                                    new LGA{LGAName="Egor" },
                                    new LGA{LGAName="Esan east" },
                                    new LGA{LGAName="Esan south" },
                                    new LGA{LGAName="Esan central" },
                                    new LGA{LGAName="Esan west" },
                                    new LGA{LGAName="Etsako central"},
                                    new LGA{LGAName="Etsako east" },
                                    new LGA{LGAName="Etsako"},
                                    new LGA{LGAName="Orhionwon"},
                                    new LGA{LGAName="Ivia north"},
                                    new LGA{LGAName="Ovia southwest"},
                                    new LGA{LGAName="Owan west"},
                                    new LGA{LGAName="Owan south"},
                                    new LGA{LGAName="Uhunwonde, "}
                                }
                            },

                            new State
                            {
                                StateName ="Ekiti",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Ado Ekiti" },
                                    new LGA{LGAName="Effon Alaiye" },
                                    new LGA{LGAName="Ekiti south west" },
                                    new LGA{LGAName="Ekiti west" },
                                    new LGA{LGAName="Ekiti east" },
                                    new LGA{LGAName="Emure" },
                                    new LGA{LGAName="ise"},
                                    new LGA{LGAName="Orun" },
                                    new LGA{LGAName="Ido"},
                                    new LGA{LGAName="Osi"},
                                    new LGA{LGAName="Ijero"},
                                    new LGA{LGAName="Ikere"},
                                    new LGA{LGAName="Ikole"},
                                    new LGA{LGAName="Ilejemeje"},
                                    new LGA{LGAName="Irepodun, "},
                                    new LGA{LGAName="Ise/Orun"},
                                    new LGA{LGAName="Moba"},
                                    new LGA{LGAName="Oye"},
                                    new LGA{LGAName="Aiyekire"}
                                }
                            },

                            new State
                            {
                                StateName ="Enugu",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Awgu" },
                                    new LGA{LGAName="Aniri" },
                                    new LGA{LGAName="Enugu east" },
                                    new LGA{LGAName="Enugu south" },
                                    new LGA{LGAName="Enugu north" },
                                    new LGA{LGAName="Ezeagu" },
                                    new LGA{LGAName="Igbo Eze north"},
                                    new LGA{LGAName="Igbi etiti" },
                                    new LGA{LGAName="Nsukka"},
                                    new LGA{LGAName="Oji river"},
                                    new LGA{LGAName="Undenu"},
                                    new LGA{LGAName="Uzo Uwani"},
                                    new LGA{LGAName="Udi"}
                                }
                            },

                            new State
                            {
                                StateName ="Gombe",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Akko" },
                                    new LGA{LGAName="Balanga" },
                                    new LGA{LGAName="Billiri" },
                                    new LGA{LGAName="Dukku" },
                                    new LGA{LGAName="Dunakaye" },
                                    new LGA{LGAName="Gombe" },
                                    new LGA{LGAName="Kaltungo"},
                                    new LGA{LGAName="Kwami" },
                                    new LGA{LGAName="Nafada"},
                                    new LGA{LGAName="Bajoga"},
                                    new LGA{LGAName="Shomgom"},
                                    new LGA{LGAName="Yamaltu"},
                                    new LGA{LGAName="Deba"}

                                }
                            },

                            new State
                            {
                                StateName ="Imo",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Aboh-mbaise" },
                                    new LGA{LGAName="Ahiazu-Mbaise" },
                                    new LGA{LGAName="Ehime-Mbaino" },
                                    new LGA{LGAName="Ezinhite" },
                                    new LGA{LGAName="Ideato North" },
                                    new LGA{LGAName="Ideato south" },
                                    new LGA{LGAName="Ihitte"},
                                    new LGA{LGAName="Uboma" },
                                    new LGA{LGAName="Ikeduru"},
                                    new LGA{LGAName="Isiala"},
                                    new LGA{LGAName="Isu"},
                                    new LGA{LGAName="Mbaitoli"},
                                    new LGA{LGAName="Ngor Okpala"},
                                    new LGA{LGAName="Njaba"},
                                    new LGA{LGAName="Nwangele, "},
                                    new LGA{LGAName="Nkwere"},
                                    new LGA{LGAName="Obowo"},
                                    new LGA{LGAName="Aguta"},
                                    new LGA{LGAName="Ohaji Egbema"},
                                    new LGA{LGAName="Okigwe"},
                                    new LGA{LGAName="Onuimo"},
                                    new LGA{LGAName="Orlu"},
                                    new LGA{LGAName="Orsu"},
                                    new LGA{LGAName="Oru west"},
                                    new LGA{LGAName="Oru"},
                                    new LGA{LGAName="Owerri"},
                                    new LGA{LGAName="Owerri North"},
                                    new LGA{LGAName="Owerri south"}
                                }
                            },

                            new State
                            {
                                StateName ="Jigawa",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Auyo" },
                                    new LGA{LGAName="Babura" },
                                    new LGA{LGAName="Birnin-Kudu" },
                                    new LGA{LGAName="Birniwa" },
                                    new LGA{LGAName="Buji" },
                                    new LGA{LGAName="Dutse" },
                                    new LGA{LGAName="Garki"},
                                    new LGA{LGAName="Gagarawa"},
                                    new LGA{LGAName="Gumel"},
                                    new LGA{LGAName="Guri"},
                                    new LGA{LGAName="Gwaram"},
                                    new LGA{LGAName="Gwiwa"},
                                    new LGA{LGAName="Hadeji"},
                                    new LGA{LGAName="Jahun"},
                                    new LGA{LGAName="Kafin-Hausa"},
                                    new LGA{LGAName="kaugama"},
                                    new LGA{LGAName="Kazaure"},
                                    new LGA{LGAName="Kirikisamma"},
                                    new LGA{LGAName="Birnin-magaji"},
                                    new LGA{LGAName="Maigatari"},
                                    new LGA{LGAName="Malamaduri"},
                                    new LGA{LGAName="Miga"},
                                    new LGA{LGAName="Ringim"},
                                    new LGA{LGAName="Roni"},
                                    new LGA{LGAName="Sule Tankarka"},
                                    new LGA{LGAName="Taura"},
                                    new LGA{LGAName="Yankwasi"}
                                }
                            },

                            new State
                            {
                                StateName ="Kaduna",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Brnin Gwari" },
                                    new LGA{LGAName="Chukun" },
                                    new LGA{LGAName="Giwa" },
                                    new LGA{LGAName="Kajuru" },
                                    new LGA{LGAName="Igabi" },
                                    new LGA{LGAName="Ikara" },
                                    new LGA{LGAName="Jaba"},
                                    new LGA{LGAName="Jema`a"},
                                    new LGA{LGAName="Kachia"},
                                    new LGA{LGAName="Kaduna North"},
                                    new LGA{LGAName="Kaduna south"},
                                    new LGA{LGAName="Kagarok"},
                                    new LGA{LGAName="Kauru"},
                                    new LGA{LGAName="Kabau"},
                                    new LGA{LGAName="Kudan"},
                                    new LGA{LGAName="Kere"},
                                    new LGA{LGAName="Makarfi"},
                                    new LGA{LGAName="Sabongari"},
                                    new LGA{LGAName="Sanga"},
                                    new LGA{LGAName="Soba"},
                                    new LGA{LGAName="Zangon-Kataf"},
                                    new LGA{LGAName="Zaria"}
                                }
                            },

                            new State
                            {
                                StateName ="Kano",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Ajigi" },
                                    new LGA{LGAName="Albasu" },
                                    new LGA{LGAName="Bagwai" },
                                    new LGA{LGAName="Bebeji" },
                                    new LGA{LGAName="Bichi" },
                                    new LGA{LGAName="Bunkure" },
                                    new LGA{LGAName="Dala"},
                                    new LGA{LGAName="Dambatta"},
                                    new LGA{LGAName="Dawakin kudu"},
                                    new LGA{LGAName="Dawakin tofa"},
                                    new LGA{LGAName="Fagge"},
                                    new LGA{LGAName="Gabasawa"},
                                    new LGA{LGAName="Garko"},
                                    new LGA{LGAName="Garun mallam"},
                                    new LGA{LGAName="Gaya"},
                                    new LGA{LGAName="Gezawa"},
                                    new LGA{LGAName="Gwale"},
                                    new LGA{LGAName="Gwarzo"},
                                    new LGA{LGAName="Kano"},
                                    new LGA{LGAName="Karay"},
                                    new LGA{LGAName="Kibiya"},
                                    new LGA{LGAName="Kiru"},
                                    new LGA{LGAName="Kumbtso"},
                                    new LGA{LGAName="Kunch"},
                                    new LGA{LGAName="Kura"},
                                    new LGA{LGAName="Maidobi"},
                                    new LGA{LGAName="Makoda"},
                                    new LGA{LGAName="MInjibir Nassarawa"},
                                    new LGA{LGAName="Rano" },
                                    new LGA{LGAName="Rimin gado" },
                                    new LGA{LGAName="Rogo" },
                                    new LGA{LGAName="Shanono" },
                                    new LGA{LGAName="Sumaila" },
                                    new LGA{LGAName="Takai"},
                                    new LGA{LGAName="Tarauni"},
                                    new LGA{LGAName="Tofa" },
                                    new LGA{LGAName="Tsanyawa" },
                                    new LGA{LGAName="Tudunwada" },
                                    new LGA{LGAName="Ungogo" },
                                    new LGA{LGAName="Warawa" },
                                    new LGA{LGAName="Wudil" }
                                }
                            },

                            new State
                            {
                                StateName ="Kastina",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Bakori" },
                                    new LGA{LGAName="Batagarawa" },
                                    new LGA{LGAName="Batsari" },
                                    new LGA{LGAName="Baure" },
                                    new LGA{LGAName="Bindawa" },
                                    new LGA{LGAName="Charanchi" },
                                    new LGA{LGAName="Dan-Musa"},
                                    new LGA{LGAName="Dandume"},
                                    new LGA{LGAName="Danja"},
                                    new LGA{LGAName="Daura"},
                                    new LGA{LGAName="Dutsin`ma"},
                                    new LGA{LGAName="Faskar"},
                                    new LGA{LGAName="Funtua"},
                                    new LGA{LGAName="Ingawa"},
                                    new LGA{LGAName="Jibiya"},
                                    new LGA{LGAName="Kafur"},
                                    new LGA{LGAName="Kaita"},
                                    new LGA{LGAName="Kankara"},
                                    new LGA{LGAName="Kankiya"},
                                    new LGA{LGAName="Katsina"},
                                    new LGA{LGAName="Furfi"},
                                    new LGA{LGAName="Kusada Mai aduwa"},
                                    new LGA{LGAName="Malumfashi"},
                                    new LGA{LGAName="Mani"},
                                    new LGA{LGAName="Matazu"},
                                    new LGA{LGAName="Mash"},
                                    new LGA{LGAName="Musawa"},
                                    new LGA{LGAName="Rimi"},
                                    new LGA{LGAName="Sabuwa" },
                                    new LGA{LGAName="Safana" },
                                    new LGA{LGAName="Sandamu" },
                                    new LGA{LGAName="Zango" }
                                }
                            },

                            new State
                            {
                                StateName ="Federal Capital Territory",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Abaji" },
                                    new LGA{LGAName="Abuja Municipal" },
                                    new LGA{LGAName="Bwari" },
                                    new LGA{LGAName="Gwagwalada" },
                                    new LGA{LGAName="Kuje" },
                                    new LGA{LGAName="Kwali" }
                                }
                            },

                            new State
                            {
                                StateName ="Kebbi",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Aliero" },
                                    new LGA{LGAName="Arewa Dandi" },
                                    new LGA{LGAName="Argungu" },
                                    new LGA{LGAName="Augie" },
                                    new LGA{LGAName="Bagudo" },
                                    new LGA{LGAName="Birnin Kebbi" },
                                    new LGA{LGAName="Bunza"},
                                    new LGA{LGAName="Dandi"},
                                    new LGA{LGAName="Danko"},
                                    new LGA{LGAName="Fakai"},
                                    new LGA{LGAName="Gwandu"},
                                    new LGA{LGAName="Jeda"},
                                    new LGA{LGAName="Kalgo"},
                                    new LGA{LGAName="Koko-besse"},
                                    new LGA{LGAName="Maiyaama"},
                                    new LGA{LGAName="Ngaski"},
                                    new LGA{LGAName="Sakaba"},
                                    new LGA{LGAName="Shanga"},
                                    new LGA{LGAName="Suru"},
                                    new LGA{LGAName="Wasugu"},
                                    new LGA{LGAName="Yauri"},
                                    new LGA{LGAName="Zuru"}
                                }
                            },

                            new State
                            {
                                StateName ="Kogi",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Adavi" },
                                    new LGA{LGAName="Ajaokuta" },
                                    new LGA{LGAName="Ankpa" },
                                    new LGA{LGAName="Bassa" },
                                    new LGA{LGAName="Dekina" },
                                    new LGA{LGAName="Yagba east" },
                                    new LGA{LGAName="Ibaji"},
                                    new LGA{LGAName="Idah"},
                                    new LGA{LGAName="Igalamela"},
                                    new LGA{LGAName="Ijumu"},
                                    new LGA{LGAName="Kabba bunu"},
                                    new LGA{LGAName="Kogi"},
                                    new LGA{LGAName="Mopa muro"},
                                    new LGA{LGAName="Ofu"},
                                    new LGA{LGAName="Ogori magongo"},
                                    new LGA{LGAName="Okehi"},
                                    new LGA{LGAName="Okene"},
                                    new LGA{LGAName="Olamaboro"},
                                    new LGA{LGAName="Omala"},
                                    new LGA{LGAName="Yagba west"}
                                }
                            },

                            new State
                            {
                                StateName ="Kwara",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Asa" },
                                    new LGA{LGAName="Baruten" },
                                    new LGA{LGAName="Ede" },
                                    new LGA{LGAName="Ifelodun" },
                                    new LGA{LGAName="Ilorin south" },
                                    new LGA{LGAName="Ilorin west" },
                                    new LGA{LGAName="Ilorin east"},
                                    new LGA{LGAName="Irepodun"},
                                    new LGA{LGAName="Isin"},
                                    new LGA{LGAName="Kaiama"},
                                    new LGA{LGAName="Moro"},
                                    new LGA{LGAName="Offa"},
                                    new LGA{LGAName="Oke ero"},
                                    new LGA{LGAName="Oyun"},
                                    new LGA{LGAName="Pategi"}
                                }
                            },

                            new State
                            {
                                StateName ="Lagos",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Agege" },
                                    new LGA{LGAName="Alimosho Ifelodun" },
                                    new LGA{LGAName="Alimosho" },
                                    new LGA{LGAName="Amuwo-Odofin" },
                                    new LGA{LGAName="Apapa" },
                                    new LGA{LGAName="Badagry" },
                                    new LGA{LGAName="Epe"},
                                    new LGA{LGAName="Eti-Osa"},
                                    new LGA{LGAName="Ibeju-Lekki"},
                                    new LGA{LGAName="Ifako"},
                                    new LGA{LGAName="Ijaye"},
                                    new LGA{LGAName="Ikeja"},
                                    new LGA{LGAName="Ikorodu"},
                                    new LGA{LGAName="Kosofe"},
                                    new LGA{LGAName="Lagos Island"},
                                    new LGA{LGAName="Lagos Mainland"},
                                    new LGA{LGAName="Mushin"},
                                    new LGA{LGAName="Ojo"},
                                    new LGA{LGAName="Oshodi-Isolo"},
                                    new LGA{LGAName="Surulere"},
                                    new LGA{LGAName="Shomolu"}
                                }
                            },

                            new State
                            {
                                StateName ="Nassarawa",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Akwanga" },
                                    new LGA{LGAName="Awe" },
                                    new LGA{LGAName="Doma" },
                                    new LGA{LGAName="Karu" },
                                    new LGA{LGAName="Keana" },
                                    new LGA{LGAName="Keffi" },
                                    new LGA{LGAName="Kokona"},
                                    new LGA{LGAName="Lafia"},
                                    new LGA{LGAName="Nassarawa"},
                                    new LGA{LGAName="Nassarawa/Eggon"},
                                    new LGA{LGAName="Obi"},
                                    new LGA{LGAName="Toto"},
                                    new LGA{LGAName="Wamba"}
                                }
                            },

                            new State
                            {
                                StateName ="Niger",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Agaie" },
                                    new LGA{LGAName="Agwara" },
                                    new LGA{LGAName="Bida" },
                                    new LGA{LGAName="Borgu" },
                                    new LGA{LGAName="Bosso" },
                                    new LGA{LGAName="Chanchanga" },
                                    new LGA{LGAName="Edati"},
                                    new LGA{LGAName="Gbako"},
                                    new LGA{LGAName="Gurara"},
                                    new LGA{LGAName="Kitcha"},
                                    new LGA{LGAName="Kontagora"},
                                    new LGA{LGAName="Lapai"},
                                    new LGA{LGAName="Lavun"},
                                    new LGA{LGAName="Magama"},
                                    new LGA{LGAName="Mariga"},
                                    new LGA{LGAName="Mokwa"},
                                    new LGA{LGAName="Muya"},
                                    new LGA{LGAName="Paiko"},
                                    new LGA{LGAName="Rafi"},
                                    new LGA{LGAName="Shiroro"},
                                    new LGA{LGAName="Suleija"},
                                    new LGA{LGAName="Tawa-Wushishi"}
                                }
                            },

                            new State
                            {
                                StateName ="Ogun",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Abeokuta south" },
                                    new LGA{LGAName="Abeokuta north" },
                                    new LGA{LGAName="Ado-odo/otta" },
                                    new LGA{LGAName="Agbado south" },
                                    new LGA{LGAName="Agbado north" },
                                    new LGA{LGAName="Ewekoro" },
                                    new LGA{LGAName="Idarapo"},
                                    new LGA{LGAName="Ifo"},
                                    new LGA{LGAName="Ijebu east"},
                                    new LGA{LGAName="Ijebu north"},
                                    new LGA{LGAName="Ikenne"},
                                    new LGA{LGAName="Ilugun Alero"},
                                    new LGA{LGAName="Imeko afon"},
                                    new LGA{LGAName="Ipokia"},
                                    new LGA{LGAName="Obafemi/owode"},
                                    new LGA{LGAName="Odeda"},
                                    new LGA{LGAName="Odogbolu"},
                                    new LGA{LGAName="Ogun waterside"},
                                    new LGA{LGAName="Sagamu"}
                                }
                            },

                            new State
                            {
                                StateName ="Ondo",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Akoko north" },
                                    new LGA{LGAName=" Akoko northeast" },
                                    new LGA{LGAName="Akoko southeast" },
                                    new LGA{LGAName="Akoko south" },
                                    new LGA{LGAName="Akure north" },
                                    new LGA{LGAName="Akure" },
                                    new LGA{LGAName="Idanre"},
                                    new LGA{LGAName="Ifedore"},
                                    new LGA{LGAName="Ese odo"},
                                    new LGA{LGAName="Ilaje"},
                                    new LGA{LGAName="Ilaje oke-igbo"},
                                    new LGA{LGAName="Irele"},
                                    new LGA{LGAName="Odigbo"},
                                    new LGA{LGAName="Ondo"},
                                    new LGA{LGAName="Ondo east"},
                                    new LGA{LGAName="Ose"},
                                    new LGA{LGAName="Owo"}
                                }
                            },

                            new State
                            {
                                StateName ="Osun",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Atakumosa west" },
                                    new LGA{LGAName="Atakumosa east" },
                                    new LGA{LGAName="Ayeda-ade" },
                                    new LGA{LGAName="Ayedire" },
                                    new LGA{LGAName="Bolawaduro" },
                                    new LGA{LGAName="Boripe" },
                                    new LGA{LGAName="Ede"},
                                    new LGA{LGAName="Ede north"},
                                    new LGA{LGAName="Egbedore"},
                                    new LGA{LGAName="Ejigbo"},
                                    new LGA{LGAName="Ife north"},
                                    new LGA{LGAName="Ife central"},
                                    new LGA{LGAName="Ife south"},
                                    new LGA{LGAName="Ife east"},
                                    new LGA{LGAName="Ifedayo"},
                                    new LGA{LGAName="Ifelodun"},
                                    new LGA{LGAName="Ilesha west"},
                                    new LGA{LGAName="Ila-orangun"},
                                    new LGA{LGAName="Ilesah east"},
                                    new LGA{LGAName="Irepodun"},
                                    new LGA{LGAName="Irewole"},
                                    new LGA{LGAName="Isokan"},
                                    new LGA{LGAName="Iwo"},
                                    new LGA{LGAName="Obokun"},
                                    new LGA{LGAName="Odo-otin"},
                                    new LGA{LGAName="ola oluwa"},
                                    new LGA{LGAName="olorunda"},
                                    new LGA{LGAName="Oriade"},
                                     new LGA{LGAName="Orolu"},
                                    new LGA{LGAName="Osogbo"}
                                }
                            },

                            new State
                            {
                                StateName ="Oyo",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Afijio" },
                                    new LGA{LGAName="Akinyele" },
                                    new LGA{LGAName="Attba" },
                                    new LGA{LGAName="Atigbo" },
                                    new LGA{LGAName="Egbeda" },
                                    new LGA{LGAName="Ibadan" },
                                    new LGA{LGAName="north east"},
                                    new LGA{LGAName="Ibadan central"},
                                    new LGA{LGAName="Ibadan south east"},
                                    new LGA{LGAName="Ibadan southwest"},
                                    new LGA{LGAName="Ibarapa east"},
                                    new LGA{LGAName="Ibarapa north"},
                                    new LGA{LGAName="Ido"},
                                    new LGA{LGAName="Ifedapo"},
                                    new LGA{LGAName="Ifeloju"},
                                    new LGA{LGAName="Irepo"},
                                    new LGA{LGAName="Iseyin"},
                                    new LGA{LGAName="Itesiwaju"},
                                    new LGA{LGAName="Iwajowa"},
                                    new LGA{LGAName="Iwajowa olorunshogo"},
                                    new LGA{LGAName="Kajola"},
                                    new LGA{LGAName="Lagelu"},
                                    new LGA{LGAName="Ogbomosho north"},
                                    new LGA{LGAName="Ogbomosho south"},
                                    new LGA{LGAName="Ogo oluwa"},
                                    new LGA{LGAName="Oluyole"},
                                    new LGA{LGAName="Ona ara"},
                                    new LGA{LGAName="Ore lope"},
                                    new LGA{LGAName="Orire"},
                                    new LGA{LGAName="Oyo east"},
                                     new LGA{LGAName="Oyo west"},
                                    new LGA{LGAName="Saki east"},
                                    new LGA{LGAName="Saki west"},
                                    new LGA{LGAName="Surulere"}
                                }
                            },

                            new State
                            {
                                StateName ="Plateau",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Barkin/ladi" },
                                    new LGA{LGAName="Bassa" },
                                    new LGA{LGAName="Bokkos" },
                                    new LGA{LGAName="Jos north" },
                                    new LGA{LGAName="Jos east" },
                                    new LGA{LGAName="Jos south" },
                                    new LGA{LGAName="Kanam"},
                                    new LGA{LGAName="kiyom"},
                                    new LGA{LGAName="Langtang north"},
                                    new LGA{LGAName="Langtang south"},
                                    new LGA{LGAName="Mangu"},
                                    new LGA{LGAName="Mikang"},
                                    new LGA{LGAName="Pankshin"},
                                    new LGA{LGAName="Qua`an pan"},
                                    new LGA{LGAName="Shendam"},
                                    new LGA{LGAName="Wase"}
                                }
                            },

                            new State
                            {
                                StateName ="Rivers",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Abua-Odial" },
                                    new LGA{LGAName="Ahoada west" },
                                    new LGA{LGAName="Akuku toru" },
                                    new LGA{LGAName="Andoni" },
                                    new LGA{LGAName="Asari toru" },
                                    new LGA{LGAName="Bonny" },
                                    new LGA{LGAName="Degema"},
                                    new LGA{LGAName="Eleme"},
                                    new LGA{LGAName="Emohua"},
                                    new LGA{LGAName="Etche"},
                                    new LGA{LGAName="Gokana"},
                                    new LGA{LGAName="Ikwerre"},
                                    new LGA{LGAName="Oyigbo"},
                                    new LGA{LGAName="Khana"},
                                    new LGA{LGAName="Obio-Akpor"},
                                    new LGA{LGAName="Ogba east"},
                                    new LGA{LGAName="Edoni"},
                                    new LGA{LGAName="Ogu/bolo"},
                                    new LGA{LGAName="Okrika"},
                                    new LGA{LGAName="Omumma"},
                                    new LGA{LGAName="Opobo/Nkoro"},
                                    new LGA{LGAName="Portharcourt"},
                                    new LGA{LGAName="Tai"}
                                }
                            },

                            new State
                            {
                                StateName ="Sokoto",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Binji" },
                                    new LGA{LGAName="Bodinga" },
                                    new LGA{LGAName="Dange/shuni" },
                                    new LGA{LGAName="Gada" },
                                    new LGA{LGAName="Goronyo" },
                                    new LGA{LGAName="Gudu" },
                                    new LGA{LGAName="Gwadabawa"},
                                    new LGA{LGAName="Illella"},
                                    new LGA{LGAName="Kebbe"},
                                    new LGA{LGAName="Kware"},
                                    new LGA{LGAName="Rabah"},
                                    new LGA{LGAName="Sabon-Birni"},
                                    new LGA{LGAName="Shagari"},
                                    new LGA{LGAName="Silame"},
                                    new LGA{LGAName="Sokoto south"},
                                    new LGA{LGAName="Sokoto north"},
                                    new LGA{LGAName="Tambuwal"},
                                    new LGA{LGAName="Tangaza"},
                                    new LGA{LGAName="Tureta"},
                                    new LGA{LGAName="Wamakko"},
                                    new LGA{LGAName="Wurno"},
                                    new LGA{LGAName="Yabo"}
                                }
                            },

                            new State
                            {
                                StateName ="Taraba",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Akdo-kola" },
                                    new LGA{LGAName="Bali" },
                                    new LGA{LGAName="Donga" },
                                    new LGA{LGAName="Gashaka" },
                                    new LGA{LGAName="Gassol" },
                                    new LGA{LGAName="Ibi" },
                                    new LGA{LGAName="Jalingo"},
                                    new LGA{LGAName="K/Lamido"},
                                    new LGA{LGAName="Kurmi"},
                                    new LGA{LGAName="lan"},
                                    new LGA{LGAName="Sardauna"},
                                    new LGA{LGAName="Tarum"},
                                    new LGA{LGAName="Ussa"},
                                    new LGA{LGAName="Wukari"},
                                    new LGA{LGAName="Yorro"},
                                    new LGA{LGAName="Zing"}
                                }
                            },

                            new State
                            {
                                StateName ="Yobe",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Borsari" },
                                    new LGA{LGAName="Damaturu" },
                                    new LGA{LGAName="Fika" },
                                    new LGA{LGAName="Fune" },
                                    new LGA{LGAName="Gogaram" },
                                    new LGA{LGAName="Gujba" },
                                    new LGA{LGAName="Gulani"},
                                    new LGA{LGAName="Jakusko"},
                                    new LGA{LGAName="Karasuwa"},
                                    new LGA{LGAName="Machina"},
                                    new LGA{LGAName="Nagere"},
                                    new LGA{LGAName="Nguru"},
                                    new LGA{LGAName="Potiskum"},
                                    new LGA{LGAName="Tarmua"},
                                    new LGA{LGAName="Tarmua"},
                                    new LGA{LGAName="Yunusari"},
                                    new LGA{LGAName="Gashua"}
                                }
                            },

                            new State
                            {
                                StateName ="Zamfara",
                                LGAs = new List<LGA>()
                                {
                                    new LGA{LGAName="Anka" },
                                    new LGA{LGAName="bukkuyum" },
                                    new LGA{LGAName="Dungudu" },
                                    new LGA{LGAName="Chafe" },
                                    new LGA{LGAName="Gummi" },
                                    new LGA{LGAName="Gusau" },
                                    new LGA{LGAName="Isa"},
                                    new LGA{LGAName="Kaura/Namoda"},
                                    new LGA{LGAName="Mradun"},
                                    new LGA{LGAName="Maru"},
                                    new LGA{LGAName="Shinkafi"},
                                    new LGA{LGAName="Talata/Mafara"},
                                    new LGA{LGAName="Zumi"}
                                }
                            }
                        }
                    }
                };

                _ctx.AddRange(country);
                _ctx.SaveChanges();
            }

            ///Seed product Category
            if (!_ctx.Categories.Any())
            {
                var categories = new List<Category>()
                {
                    new Category(){ Name = "Cement" },
                    new Category(){ Name = "Tiles" },
                    new Category(){ Name = "Blocks" },
                    new Category(){ Name = "Paints" },
                    new Category(){ Name = "POP" },
                    new Category(){ Name = "Marbles" },
                    new Category(){ Name = "Roofing Sheets" }
                };

                _ctx.AddRange(categories);
                _ctx.SaveChanges();
            } 
            

           
            ///Seed product with sample data
            if (!_ctx.Products.Any())
            {
                var product = new List<Product>()
                {
                    new Product()
                    {
                        CategoryId = _ctx.Categories.Single(s => s.Name == "Cement").Id,
                        Name = "DEMO Dangote Cement",
                        Date = DateTime.Now.Date,
                        Quantity = "50",
                        Unit = "kg",
                        ProductUrl="dangoteCement.png",
                        Price = 4500,
                        Categories = _ctx.Categories.Single(s => s.Name == "Cement"),
                        Markets = new List<Market>()
                        { 
                            new Market() { MarketName = "Deidei" },
                            new Market() { MarketName = "Lagos" },
                            new Market() { MarketName = "Sokoto" }
                        },
                       // Histories = _ctx.Historys.Where(s => s.ProductId == 1),
                       // Sellers = _ctx.Sellers.Where(s => s.Products.Any(p => p.ProductId == 1))
                    },

                    new Product()
                    {
                        CategoryId = _ctx.Categories.Single(s => s.Name == "Cement").Id,
                        Name = "DEMO BUA Cement",
                        Date = DateTime.Now.Date,
                        Quantity = "50",
                        Unit ="kg",
                        ProductUrl="BUACement.png",
                        Price = 4300,
                        Categories = _ctx.Categories.Single(s => s.Name == "Cement"),
                        Markets = new List<Market>()
                        {
                            new Market() { MarketName = "Kano" },
                            new Market() { MarketName = "Portharcourt" },
                            new Market() { MarketName = "Nnewi" }
                        },
                        //Histories = _ctx.Historys.Where(s => s.ProductId == 2),
                        //Sellers = _ctx.Sellers.Where(s => s.Products.Any(p => p.ProductId == 2))
                    },

                    new Product()
                    {
                        CategoryId = _ctx.Categories.Single(s => s.Name == "Tiles").Id,
                        Name = "DEMO Spanish Tiles 60 by 60",
                        Date = DateTime.Now.Date,
                        Quantity = "1",
                        Unit ="Sqaure metre",
                        ProductUrl="SpanishTiles60by60.png",
                        Price = 3400,
                        Categories = _ctx.Categories.Single(s => s.Name == "Tiles"),
                        Markets = _ctx.Markets.Where(s => s.MarketName == "Lagos")
                        //Histories = _ctx.Historys.Where(s => s.ProductId == 3),
                        //Sellers = _ctx.Sellers.Where(s => s.Products.Any(p => p.ProductId == 3))
                    }
                };

               await _ctx.AddRangeAsync(product);
                _ctx.SaveChanges();
            }


            ///seed Sellers
            if (!_ctx.Sellers.Any())
            {
                var sellers = new List<Seller>()
                {
                    new Seller()
                    {
                        SellerName = "Michael Okpara",
                        BussinessName = "Blessed Ventures",
                        SellerDescription = "Cras dignissim quam sollicitudin, lobortis dolor a, vestibulum nunc",
                        MarketName = "Deidei",
                        MarketId = _ctx.Markets.FirstOrDefault(p => p.MarketName == "Deidei").MarketId,
                        Products = _ctx.Products.Where(s => s.Name =="DEMO Dangote Cement").ToList(),
                        contact = new Contact()
                        {
                            Address = "12 mango Bleck",
                            Landmarks = "by ABC Motor Park",
                            Town = "Deidei",
                            LGA = "Bwari",
                            State = "Federal Capital Territory",
                            Country = "Nigeria"
                        }
                    },

                    new Seller()
                    {
                        SellerName = "Abubakar Sule",
                        BussinessName = "Sule Cement Dealership",
                        SellerDescription = "Fringilla metus a, sagittis quam, lobortis dolor a, vestibulum nunc",
                        MarketName = "Deidei",
                        MarketId = _ctx.Markets.FirstOrDefault(p => p.MarketName == "Deidei").MarketId,
                        Products = _ctx.Products.Where(s => s.Name =="DEMO BUA Cement").ToList(),
                        contact = new Contact()
                        {
                            Address = "34 Niger way",
                            Landmarks = "opp Ray Power",
                            Town = "Deidei",
                            LGA = "Bwari",
                            State = "Federal Capital Territory",
                            Country = "Nigeria"
                        }
                    },

                    new Seller()
                    {
                        SellerName = "Wale Adenuga",
                        BussinessName = "Wole World",
                        SellerDescription = "Quam, lobortis dolor a vestibulum nunc fringilla metus a, sagittis quam, lobortis dolor a, vestibulum nunc",
                        MarketName = "Lagos",
                        MarketId = _ctx.Markets.FirstOrDefault(p => p.MarketName == "Deidei").MarketId,
                        Products = _ctx.Products.Where(s => s.Name == "DEMO Spanish Tiles 60 by 60").ToList(),
                        contact = new Contact()
                        {
                            Address = "28 Magogo Road",
                            Landmarks = "Beside LASU Staff Qtrs",
                            Town = "Illupeju",
                            LGA = "Lagos Mainland",
                            State = "Lagos",
                            Country = "Nigeria"
                        }
                    },

                    new Seller()
                    {
                        SellerName = "Yakubu Dosa",
                        BussinessName = "Easy Things Ventures",
                        SellerDescription = "Vestibulum nunc quam, lobortis dolor a vestibulum nunc fringilla metus a, sagittis quam, lobortis dolor",
                        MarketName = "Sokoto",
                        MarketId = _ctx.Markets.FirstOrDefault(p => p.MarketName == "Lagos").MarketId,
                        Products = _ctx.Products.Where(s => s.Name == "DEMO Dangote Cement").ToList(),
                        contact = new Contact()
                        {
                            Address = "19 Kasuwa road",
                            Landmarks = "Barinini",
                            Town = "Sokoto",
                            LGA = "Sokoto south",
                            State = "Sokoto",
                            Country = "Nigeria"
                        }
                    }

                };

                await _ctx.AddRangeAsync(sellers);
                _ctx.SaveChanges();              
            }


            ///seed Product History
            if (!_ctx.Historys.Any())
            {
                var histories = new List<History>()
                {
                    ///Sample Histories for Dangote Cements
                    new History()
                    {
                         ProductId = _ctx.Products.FirstOrDefault(p => p.Name =="DEMO Dangote Cement").ProductId,
                         DateAdded = DateTime.Parse("14/08/2023"),
                         Prices = 4500                        
                    },

                    new History()
                    {
                         ProductId = _ctx.Products.FirstOrDefault(p => p.Name =="DEMO Dangote Cement").ProductId,
                         DateAdded = DateTime.Parse("07/08/2023"),
                         Prices = 4500
                    },

                    new History()
                    {
                         ProductId =_ctx.Products.FirstOrDefault(p => p.Name =="DEMO Dangote Cement").ProductId,
                         DateAdded = DateTime.Parse("31/07/2023"),
                         Prices = 4500
                    },

                    new History()
                    {
                         ProductId = _ctx.Products.FirstOrDefault(p => p.Name =="DEMO Dangote Cement").ProductId,
                         DateAdded = DateTime.Parse("24/07/2023"),
                         Prices = 4500
                    },

                    new History()
                    {
                         ProductId = _ctx.Products.FirstOrDefault(p => p.Name =="DEMO Dangote Cement").ProductId,
                         DateAdded = DateTime.Parse("17/07/2023"),
                         Prices = 4400
                    },


                    ///Sample Data for BUA Cements
                    new History()
                    {
                         ProductId =_ctx.Products.FirstOrDefault(p => p.Name =="DEMO BUA Cement").ProductId,
                         DateAdded = DateTime.Parse("14/08/2023"),
                         Prices = 4300
                    },

                    new History()
                    {
                         ProductId = _ctx.Products.FirstOrDefault(p => p.Name =="DEMO BUA Cement").ProductId,
                         DateAdded = DateTime.Parse("07/08/2023"),
                         Prices = 4300
                    },

                    new History()
                    {
                         ProductId = _ctx.Products.FirstOrDefault(p => p.Name =="DEMO BUA Cement").ProductId,
                         DateAdded = DateTime.Parse("31/07/2023"),
                         Prices = 4250
                    },

                    new History()
                    {
                         ProductId = _ctx.Products.FirstOrDefault(p => p.Name =="DEMO BUA Cement").ProductId,
                         DateAdded = DateTime.Parse("24/07/2023"),
                         Prices = 4200
                    },


                    ///Sample Data for DEMO Spanish Tiles 60 by 60
                    new History()
                    {
                         ProductId = _ctx.Products.FirstOrDefault(p => p.Name =="DEMO Spanish Tiles 60 by 60").ProductId,
                         DateAdded = DateTime.Parse("14/08/2023"),
                         Prices = 3400
                    },

                    new History()
                    {
                         ProductId = _ctx.Products.FirstOrDefault(p => p.Name =="DEMO Spanish Tiles 60 by 60").ProductId,
                         DateAdded = DateTime.Parse("07/08/2023"),
                         Prices = 3300
                    },

                    new History()
                    {
                         ProductId = _ctx.Products.FirstOrDefault(p => p.Name =="DEMO Spanish Tiles 60 by 60").ProductId,
                         DateAdded = DateTime.Parse("31/07/2023"),
                         Prices = 3400
                    },

                    new History()
                    {
                         ProductId = _ctx.Products.FirstOrDefault(p => p.Name =="DEMO Spanish Tiles 60 by 60").ProductId,
                         DateAdded = DateTime.Parse("24/07/2023"),
                         Prices = 3200
                    },
                };

               await _ctx.AddRangeAsync(histories);
                _ctx.SaveChanges();
            }





            ///Seed Markets
            //if (!_ctx.Markets.Any()) 
            //{
            //    var markets = new List<Market>()
            //    {
            //        new Market() { MarketName = "Deidei" },
            //        new Market() { MarketName = "Lagos" },
            //        new Market() { MarketName = "Kano" },
            //        new Market() { MarketName = "Portharcourt" },
            //        new Market() { MarketName = "Nnewi" },
            //        new Market() { MarketName = "Sokoto" }
            //    };

            //    _ctx.AddRange(markets);
            //    _ctx.SaveChanges();
            //}
        }
    }
}
