﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celikoor_LIB
{
    public class Konsumen
    {
        private int id;
        private string nama;
        private string email;
        private string noHp;
        private char gender; //enum
        private DateTime tglLahir;
        private double saldo;
        private string username;
        private string password;

        public Konsumen()
        {
            Nama = "";
            Email = "";
            NoHp = "";
            Gender = 'N';
            TglLahir = DateTime.Now;
            Saldo = 0;
            Username = "";
            Password = "";
        }

        public Konsumen(int id, string nama, string email, string noHp, char gender, DateTime tglLahir, double saldo, string username, string password)
        {
            Id = id;
            Nama = nama;
            Email = email;
            NoHp = noHp;
            Gender = gender;
            TglLahir = tglLahir;
            Saldo = saldo;
            Username = username;
            Password = password;
        }

        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public string NoHp { get => noHp; set => noHp = value; }
        public char Gender { get => gender; set => gender = value; }
        public DateTime TglLahir { get => tglLahir; set => tglLahir = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Id { get => id; set => id = value; }

        public static void TambahData(Konsumen k)
        {
            //susun perintah query
            string perintah = " INSERT INTO ;";
            Koneksi.JalankanPerintahQuery(perintah); //kirim ke command
        }

        public static void UbahData(Konsumen k)
        {
            //susun perintah query
            string perintah = "update kategori set;";
            Koneksi.JalankanPerintahQuery(perintah); //kirim ke command
        }

        public static void HapusData(string kodeHapus)
        {
            //susun perintah query
            string perintah = "delete from kategori where kodekategori='" + kodeHapus + "';";
            Koneksi.JalankanPerintahQuery(perintah); //kirim ke command
        }

        public static List<Konsumen> BacaData(string filter = "", string nilai = "")
        {
            //susun perintah query
            string perintah;
            if (filter == "")
            {
                perintah = "select * from kategori";
            }
            else
            {
                perintah = "select * from kategori where " + filter + " like '%" + nilai + "%'";
            }
            //eksekusi perintah di atas
            MySqlDataReader hasil = Koneksi.JalankanPerintahSelect(perintah);
            List<Konsumen> ListData = new List<Konsumen>();

            //selama masih ada data yang dapat dibaca dari datareader
            while (hasil.Read() == true)
            {   //ambil isi datareader
                string tampungKode = hasil.GetValue(0).ToString(); //kolom pertama
                string tampungNama = hasil.GetValue(1).ToString(); //kolom kedua
                //tampung ke sebuah objek kategori
                Konsumen tampung = new Konsumen();
                //tambahkan ke list
                ListData.Add(tampung);
            }
            //kirim list ke pemanggilnya
            return ListData;
        }
    }
}