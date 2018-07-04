using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;
using System.IO;
using PCpremiumFB.Data;
using PCpremiumFB.HelpProg;

namespace PCpremiumFB
{
    public /*sealed*/ partial class Form1 : Form
    {
        Items hero = new Items();
        public static List<Items> orderList;
        public int x = 1;

        public Form1()
        {
            InitializeComponent();
            CheckDate();
            GetDataReal();
            GetDataDone();
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            UIform u = new UIform();
            u.Show();
            GetDataReal();
            GetDataDone();
        }

        private void GetDataReal() {
            orderList = new List<Items>();
            Conn conn = new Conn();
            Task.Run(() => conn.Get("PC/")).Wait();
            dataGridViewReal.DataSource = orderList;
        }

        private void GetDataSearch(string needle, string indicate)
        {
            orderList = new List<Items>();
            Conn conn = new Conn();
            if (indicate == "Name"){Task.Run(() => conn.SearchName(needle)).Wait();}
            if (indicate == "Date") {Task.Run(() => conn.SearchDate(needle)).Wait();}
            dataGridViewSearch.DataSource = orderList;
        }

        private void GetDataDone()
        {
            orderList = new List<Items>();
            Conn conn = new Conn();
            Task.Run(() => conn.Get("Zamkniete/")).Wait();
            dataGridViewDone.DataSource = orderList;
        }

        private void CheckDate() {
            Conn conn = new Conn();
            Task.Run(() => conn.DataCheck()).Wait();
        }

        private void dataGridViewReal_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            timer.Stop();
            insertDataTOGrid(dataGridViewReal);
            timer.Start();
        }

        private void dataGridViewDone_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            timer.Stop();
            insertDataTOGrid(dataGridViewDone);
            timer.Start();
        }

        private void bttnReload_Click(object sender, EventArgs e)
        {
            GetDataReal();
            GetDataDone();
        }

        private void pbMenu_Click(object sender, EventArgs e)
        {
            if (panelLeft.Width < 100)
            {
                for (int i = 0; i < 60; i++)
                {
                    panelLeft.Width += 3;
                }
                checkSliderPosition();
                txt1.Visible = true; txt2.Visible = true; txt3.Visible = true; txt4.Visible = true;
            }
            else {
                for (int i = 0; i < 60; i++)
                {
                    panelLeft.Width -= 3;
                }
                txt1.Visible = false; txt2.Visible = false; txt3.Visible = false; txt4.Visible = false;
            }
        }

        private void bttnOpened_Click(object sender, EventArgs e)
        {
            if (dataGridViewReal.Visible != true)
            {
                dataGridViewDone.Visible = false;
                dataGridViewReal.Visible = true;
                dataGridViewSearch.Visible = false;
                panelSearch.Visible = false;
            }
            SliderMoves(txt1.Text, ((Button)sender).Location.Y);
        }

        private void bttnClosed_Click(object sender, EventArgs e)
        {
            if (dataGridViewDone.Visible != true)
            {
                dataGridViewDone.Visible = true;
                dataGridViewReal.Visible = false;
                dataGridViewSearch.Visible = false;
                panelSearch.Visible = false;
            }
            SliderMoves(txt2.Text, ((Button)sender).Location.Y);
        }

        private void bttnSearch_Click(object sender, EventArgs e)
        {
            if (dataGridViewSearch.Visible == false)
            {
                dataGridViewSearch.Visible = true;
                panelSearch.Visible = true;
                dataGridViewDone.Visible = false;
                dataGridViewReal.Visible = false;
            }
            SliderMoves(txt3.Text, ((Button)sender).Location.Y);
        }

        private void bttnGo_Click(object sender, EventArgs e)
        {
            GetDataSearch(txtSearch.Text, cbSearch.Text);
        }

        private void SliderMoves(string needle, int y) {
            if (panelLeft.Width > 80)
            {
                slider.Visible = false;
                txt4.Text = needle;
                slider.Location = new Point(60, y);
                slider.Visible = true;
            }
            else {
                slider.Visible = true;
                slider.Location = new Point(60, y);
            }
        }

        private void checkSliderPosition() {
            if (slider.Location.Y == bttnSearch.Location.Y)
            {
                txt4.Text = txt3.Text;
            }
            else if (slider.Location.Y == bttnClosed.Location.Y)
            {
                txt4.Text = txt2.Text;
            }
            else {
                txt4.Text = txt1.Text;
            }
        }

        private void insertDataTOGrid(DataGridView needle) {
            UIform uif = new UIform();
            helpingFill hf = new helpingFill();
            uif.Show();

            if (needle == dataGridViewDone)
            {
                uif.bttnZapisz.Enabled = false;
                uif.bttnEdytuj.Enabled = false;
                uif.bttnUsun.Enabled = true;
                uif.bttnZakoncz.Enabled = false;
                //uif.lblSt.Visible = true;
                //uif.lblStworzyl.Visible = true;
            }
            else {
                uif.bttnZapisz.Enabled = false;
            }

            uif.lblId.Text = needle.SelectedRows[0].Cells[0].Value.ToString();
            uif.txtKlient.Text = needle.SelectedRows[0].Cells[1].Value.ToString();
            uif.dtPicker.Text = needle.SelectedRows[0].Cells[2].Value.ToString();
            uif.txtCena.Text = needle.SelectedRows[0].Cells[3].Value.ToString();
            uif.txtModel.Text = needle.SelectedRows[0].Cells[4].Value.ToString();
            hf.fComCase(uif, needle.SelectedRows[0].Cells[5].Value.ToString());
            uif.txtRozmiar.Text = needle.SelectedRows[0].Cells[6].Value.ToString();
            hf.fDisc1Type(uif, needle.SelectedRows[0].Cells[7].Value.ToString());
            hf.fDisc1Old(uif, needle.SelectedRows[0].Cells[8].Value.ToString());
            uif.txtRozmiar2.Text = needle.SelectedRows[0].Cells[9].Value.ToString();
            hf.fDisc2Type(uif, needle.SelectedRows[0].Cells[10].Value.ToString());
            hf.fDisc2Old(uif, needle.SelectedRows[0].Cells[11].Value.ToString());
            hf.fCD(uif, needle.SelectedRows[0].Cells[12].Value.ToString());
            hf.fComSystem(uif, needle.SelectedRows[0].Cells[13].Value.ToString());
            hf.fComSystemBit(uif, needle.SelectedRows[0].Cells[14].Value.ToString());
            hf.fComSystemB(uif, needle.SelectedRows[0].Cells[15].Value.ToString());
            hf.fComSystemHmPr(uif, needle.SelectedRows[0].Cells[16].Value.ToString());
            hf.fComSystemOrig(uif, needle.SelectedRows[0].Cells[17].Value.ToString());
            uif.txtUwagi.Text = needle.SelectedRows[0].Cells[18].Value.ToString();
            uif.txtKGraficzna.Text = needle.SelectedRows[0].Cells[19].Value.ToString();
            uif.txtRAM.Text = needle.SelectedRows[0].Cells[20].Value.ToString();
            uif.txtMatryca.Text = needle.SelectedRows[0].Cells[21].Value.ToString();
            uif.txtKlawiatura.Text = needle.SelectedRows[0].Cells[22].Value.ToString();
            hf.fOrder(uif, needle.SelectedRows[0].Cells[23].Value.ToString());
            hf.fPayment(uif, needle.SelectedRows[0].Cells[24].Value.ToString());
            uif.txtTransport.Text = needle.SelectedRows[0].Cells[25].Value.ToString();
            uif.txtInstrukcje.Text = needle.SelectedRows[0].Cells[26].Value.ToString();
            //uif.lblStworzyl.Text = needle.SelectedRows[0].Cells[27].Value.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            GetDataReal();
            GetDataDone();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (AccessCheck.User == "Leon") {
                panelTop.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                bttnAdd.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                bttnAdd.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                bttnReload.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                bttnReload.FlatAppearance.BorderColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                slider.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
                txt4.BackColor = Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));

                panelLeft.BackColor = Color.Gray;
                pbMenu.BackColor = Color.Gray;
                bttnOpened.BackColor = Color.Gray;
                bttnOpened.FlatAppearance.BorderColor = Color.Gray;
                bttnClosed.BackColor = Color.Gray;
                bttnClosed.FlatAppearance.BorderColor = Color.Gray;
                bttnSearch.BackColor = Color.Gray;
                bttnSearch.FlatAppearance.BorderColor = Color.Gray;
                txt1.BackColor = Color.Gray;
                txt2.BackColor = Color.Gray;
                txt3.BackColor = Color.Gray;
            }
        }

        // ADD
        /*while (true) {
            DateTime date = DateTime.Now;
            string Date = date.ToString("yyyy:MM:dd");
            string Time = date.ToString("HH:mm:ss");

            var json = JsonConvert.SerializeObject(new
            {
                Name = Time,
                Value = Date,
                ID = "test"
            });

            var request = WebRequest.CreateHttp("https://pcpremiumdb.firebaseio.com/.json");
            request.Method = "POST";
            request.ContentType = "application/json";

            var buffer = Encoding.UTF8.GetBytes(json);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);

            var response = request.GetResponse();
            json = (new StreamReader(response.GetResponseStream())).ReadToEnd();
        }*/

        //DELETE
        /*while (true) {
            var request = WebRequest.CreateHttp("https://pcpremiumdb.firebaseio.com/.json");
            request.Method = "DELETE";
            request.ContentType = "application/json";

            var response = request.GetResponse();
        }*/

        //uifDATE
        /*while (true) {
            DateTime date = DateTime.Now;
            string Date = date.ToString("yyyy:MM:dd");
            string Time = date.ToString("HH:mm:ss");

            var json = JsonConvert.SerializeObject(new
            {
                Name = Time,
                Value = Date,
            });

            var request = WebRequest.CreateHttp("https://pcpremiumdb.firebaseio.com/.json");
            request.Method = "PATCH";
            request.ContentType = "application/json";

            var buffer = Encoding.UTF8.GetBytes(json);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);

            var response = request.GetResponse();
            json = (new StreamReader(response.GetResponseStream())).ReadToEnd();
        }*/

        /*while (true) {
            string URL = "https://pcpremiumdb.firebaseio.com/.json";
            HttpWebRequest request1 = (HttpWebRequest)WebRequest.Create(URL);
            request1.ContentType = "application/json: charset=utf-8";
            HttpWebResponse response1 = request1.GetResponse() as HttpWebResponse;

            using (Stream resposestrim = response1.GetResponseStream()) {
                StreamReader Read = new StreamReader(resposestrim, Encoding.UTF8);
                Console.WriteLine(Read.ReadToEnd());
            }
        }*/
    }
}
