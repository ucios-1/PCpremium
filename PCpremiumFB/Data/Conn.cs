using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;

namespace PCpremiumFB.Data
{
    public class Conn
    {
        private const String databaseUrl = "https://pcpremiumdb.firebaseio.com/";
        private const String databaseSecret = "usdu89eKHKRJlzDzesyQrntHuVVVTZZaaEn3E5WO";
        private const String nodeReal = "PC/";
        private const String nodeDone = "Zamkniete/";
        private const String nodeLogo = "Login/";

        private FirebaseClient firebase;

        public Conn() {
            this.firebase = new FirebaseClient(databaseUrl, new FirebaseOptions {
                AuthTokenAsyncFactory = () => Task.FromResult(databaseSecret)
            });
        }

        public async Task Insert(Items item) {
            await firebase.Child(nodeReal).PostAsync<Items>(item);
        }

        public async Task Insert(Items hero, string path)
        {
            await firebase.Child(path).PostAsync<Items>(hero);
        }

        public async void Update(Items item, string key) {
            await firebase.Child(nodeReal).Child(key).PutAsync<Items>(item);
        }

        public async Task Delete(string item) {
            await firebase.Child(nodeReal).Child(item).DeleteAsync();
        }

        public async Task DataCheck() {
            var results = await firebase.Child(nodeDone).OnceAsync<Items>();
            DateTime dt7 = DateTime.Now.AddMonths(-3);
            foreach (var item in results) {
                if (DateTime.Parse(item.Object.Data) < dt7) {
                    await firebase.Child(nodeDone).Child(item.Key).DeleteAsync();
                }
            }
        }

        public async Task LoginGet(string needle) {
            var results = await firebase.Child(nodeLogo).OnceAsync<LoginItems>();
            Login.loginList = new List<LoginItems>();

            foreach (var item in results) {
                Login.loginList.Add(new LoginItems
                {
                    UserLogin = item.Object.UserLogin,
                    UserPassword = item.Object.UserPassword
                });
            }
        }

        public async Task Get(string path) {
            var results = await firebase.Child(path).OnceAsync<Items>();
            Form1.orderList = new List<Items>();

            foreach (var item in results) {
                Form1.orderList.Add(new Items {
                    Klient = item.Object.Klient,
                    Data = item.Object.Data,
                    Cena = item.Object.Cena,
                    Model = item.Object.Model,
                    Obudowa = item.Object.Obudowa,
                    Poj_Dysku1 = item.Object.Poj_Dysku1,
                    Rodz_Dysku1 = item.Object.Rodz_Dysku1,
                    Stan_Dysku1 = item.Object.Stan_Dysku1,
                    Poj_Dysku2 = item.Object.Poj_Dysku2,
                    Rodz_Dysku2 = item.Object.Rodz_Dysku2,
                    Stan_Dysku2 = item.Object.Stan_Dysku2,
                    CD = item.Object.CD,
                    System = item.Object.System,
                    SystemBit = item.Object.SystemBit,
                    SystemB = item.Object.SystemB,
                    System_Hm_Pr = item.Object.System_Hm_Pr,
                    System_Orig = item.Object.System_Orig,
                    Uwagi = item.Object.Uwagi,
                    Karta_wideo = item.Object.Karta_wideo,
                    RAM = item.Object.RAM,
                    Matryca = item.Object.Matryca,
                    Klawiatura = item.Object.Klawiatura,
                    Płatność = item.Object.Płatność,
                    Zamówione = item.Object.Zamówione,
                    Transport = item.Object.Transport,
                    Instrukcje = item.Object.Instrukcje,
                    Key = item.Key
                });
            }
        }

        public async Task SearchName(string needle)
        {
            var results = await firebase.Child(nodeDone).OnceAsync<Items>();
            Form1.orderList = new List<Items>();

            foreach (var item in results)
            {
                if (item.Object.Klient.Contains(needle))
                {
                    Form1.orderList.Add(new Items
                    {
                        Klient = item.Object.Klient,
                        Data = item.Object.Data,
                        Cena = item.Object.Cena,
                        Model = item.Object.Model,
                        Obudowa = item.Object.Obudowa,
                        Poj_Dysku1 = item.Object.Poj_Dysku1,
                        Rodz_Dysku1 = item.Object.Rodz_Dysku1,
                        Stan_Dysku1 = item.Object.Stan_Dysku1,
                        Poj_Dysku2 = item.Object.Poj_Dysku2,
                        Rodz_Dysku2 = item.Object.Rodz_Dysku2,
                        Stan_Dysku2 = item.Object.Stan_Dysku2,
                        CD = item.Object.CD,
                        System = item.Object.System,
                        SystemBit = item.Object.SystemBit,
                        SystemB = item.Object.SystemB,
                        System_Hm_Pr = item.Object.System_Hm_Pr,
                        System_Orig = item.Object.System_Orig,
                        Uwagi = item.Object.Uwagi,
                        Karta_wideo = item.Object.Karta_wideo,
                        RAM = item.Object.RAM,
                        Matryca = item.Object.Matryca,
                        Klawiatura = item.Object.Klawiatura,
                        Płatność = item.Object.Płatność,
                        Zamówione = item.Object.Zamówione,
                        Transport = item.Object.Transport,
                        Instrukcje = item.Object.Instrukcje,
                        Key = item.Key
                    });
                }
            }
        }

        public async Task SearchDate(string needle)
        {
            var results = await firebase.Child(nodeDone).OnceAsync<Items>();
            Form1.orderList = new List<Items>();

            foreach (var item in results)
            {
                if (item.Object.Data.Contains(needle))
                {
                    Form1.orderList.Add(new Items
                    {
                        Klient = item.Object.Klient,
                        Data = item.Object.Data,
                        Cena = item.Object.Cena,
                        Model = item.Object.Model,
                        Obudowa = item.Object.Obudowa,
                        Poj_Dysku1 = item.Object.Poj_Dysku1,
                        Rodz_Dysku1 = item.Object.Rodz_Dysku1,
                        Stan_Dysku1 = item.Object.Stan_Dysku1,
                        Poj_Dysku2 = item.Object.Poj_Dysku2,
                        Rodz_Dysku2 = item.Object.Rodz_Dysku2,
                        Stan_Dysku2 = item.Object.Stan_Dysku2,
                        CD = item.Object.CD,
                        System = item.Object.System,
                        SystemBit = item.Object.SystemBit,
                        SystemB = item.Object.SystemB,
                        System_Hm_Pr = item.Object.System_Hm_Pr,
                        System_Orig = item.Object.System_Orig,
                        Uwagi = item.Object.Uwagi,
                        Karta_wideo = item.Object.Karta_wideo,
                        RAM = item.Object.RAM,
                        Matryca = item.Object.Matryca,
                        Klawiatura = item.Object.Klawiatura,
                        Płatność = item.Object.Płatność,
                        Zamówione = item.Object.Zamówione,
                        Transport = item.Object.Transport,
                        Instrukcje = item.Object.Instrukcje,
                        Key = item.Key
                    });
                }
            }
        }
    }
}
