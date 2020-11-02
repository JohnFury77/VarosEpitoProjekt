using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VarosEpitoProjekt
{
    class Varos
    {
        string nev;
        int lakosok;
        int hazak;
        int uzletek;


        public Varos(string nev, int meret)
        {

            this.nev = nev;
            if (meret == 1)
            {
                this.hazak = 150; this.uzletek = 20;
            }
            else if (meret == 2)
            {
                this.hazak = 300; this.uzletek = 45;
            }
            else if (meret == 3)
            {

                this.hazak = 450; this.uzletek = 50;
            }
            this.lakosok = this.MaxLakosok / 2;

        }

        public string Nev
        {
            get
            {
                return this.nev;
            }
        }
        public int Lakosok
        {
            get
            {
                return this.lakosok;
            }
            set
            {
                if (this.lakosok > value)
                {
                    Console.WriteLine("A lakosok száma nem csökkenhet!");
                }
                else if (this.Lakosok > this.MaxLakosok)
                {
                    Console.WriteLine("A lakosok száma nem lehet több mint a maximum!");
                }
                else
                {
                    this.lakosok = value;
                }
            }
        }

        public int Hazak
        {
            get
            {
                return this.hazak;
            }
            set
            {
                if (this.MaxLakosok < this.lakosok)
                {
                    Console.WriteLine("Nem lépheti át");
                }
                else
                {
                    this.hazak = value;
                }
            }
        }
        public int Uzletek
        {
            get
            {
                return this.uzletek;
            }
        }

        public int MaxLakosok
        {
            get
            {
                return this.hazak * 6;
            }
        }
        public double Alapterulet
        {
            get
            {
                return this.hazak * 110 + this.uzletek * 85.5;
            }
        }
        public void UzletetEpit(int db)
        {
            if (db == 0 || db < 0)
            {
                throw new ArgumentException("Nem lehet 0 vagy negatív!");
            }

            else if (lakosok / 20 > uzletek)
            {
                this.uzletek += db;
            }

            else
            {
                int MaxUzletek = lakosok / 20;
                Console.WriteLine("Nem lehet több üzletet építeni!");
            }

        }

        public int CompareTo(Varos masikVaros)
        {
            if (this.Alapterulet == masikVaros.Alapterulet)
            {
                return 0;
            }
            else if (this.Alapterulet < masikVaros.Alapterulet)
            {
                return -5;
            }
            else
            {
                return 5;
            }
        }
        public override string ToString()
        {
            return String.Format
                ($"{this.nev} - Lakosok: {(this.lakosok/this.MaxLakosok)} - Üzletek: {this.uzletek} - Alapterület: {this.Alapterulet}m2" );
        }

        internal void UzletetEpit()
        {
            throw new NotImplementedException();
        }
    }
}

