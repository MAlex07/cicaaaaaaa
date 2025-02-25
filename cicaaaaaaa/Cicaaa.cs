using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cicaaaaaaa
{
    internal class Cicaaa
    {
        Random random = new Random();

        private string nev;
        int kor;
        int suly;
        string fajta;
        string szin;
        int rendetlensegSzint;
        int fogyasztas;
        bool ehes;
        string nem;

        public Cicaaa(string nev, int kor, int suly, string fajta, string szin, int rendetlensegSzint, int fogyasztas, string nem)
        {

            this.nev = nev;
            this.kor = kor;
            this.suly = suly;
            this.fajta = fajta;
            this.szin = szin;
            this.rendetlensegSzint = rendetlensegSzint;
            this.fogyasztas = fogyasztas;
            this.nem = nem;
            ehes = true;
        }

        public void Eves(double kajaSuly)
        {
            int esely = random.Next(101);
            ehes = false;

            if (esely <= 4)
            {
                szin = "zöld";
                suly -= (int)(suly * (esely / 100.0));
                rendetlensegSzint /= 2;
            }
            else
            {
                suly += (int)Math.Ceiling(fogyasztas * kajaSuly);
            }
        }

        public void Alvas()
        {
            rendetlensegSzint = 0;

            if (szin == "zöld")
            {
                szin = "eredeti";
            }
        }

        public void Ebredes()
        {
            rendetlensegSzint = 100;
            ehes = true;
        }

        public void Jatek()
        {
            List<string> tevekenysegek = new List<string> { "gombolyoggal játszik", "leveri a virágokat", "megeszi az akváriumi halakat", "letépi a függönyt", "szétszedi a kanapét", "romlott kaját evett" };
            Random r = new Random();
            int hanyTevékenység = r.Next(1, tevekenysegek.Count);

            if (rendetlensegSzint == 0)
            {
                Alvas();
            }
            else if (rendetlensegSzint>0 && rendetlensegSzint<=30)
            {
                Console.WriteLine($"{nev} ezt csinálja: {tevekenysegek[0]}");
            }
            else if (rendetlensegSzint > 30 && rendetlensegSzint <= 70)
            {
                Console.WriteLine($"{nev} ezt csinálja: {tevekenysegek[1]} és {tevekenysegek[2]}");
            }
            else if (rendetlensegSzint > 70)
            {
                Console.WriteLine($"{nev} ezt csinálja: {tevekenysegek[3]} és {tevekenysegek[4]} mellesleg {tevekenysegek[5]}");
                Eves(10);
            }



        }

        public void Oregedes()
        {
            if (kor < 3)
            {
                rendetlensegSzint += 20;
                Console.WriteLine($"A korából adódó új rendetlenségi szintje: {rendetlensegSzint}");
            }
            else if (kor > 3 && kor < 6)
            {
                rendetlensegSzint += 15;
                Console.WriteLine($"A korából adódó új rendetlenségi szintje: {rendetlensegSzint}");
            }
            else if (kor > 6 && kor < 12)
            {
                rendetlensegSzint += 5;
                Console.WriteLine($"A korából adódó új rendetlenségi szintje: {rendetlensegSzint}");
            }
            else
            {
                rendetlensegSzint += 0;
                Console.WriteLine($"A korából adódó új rendetlenségi szintje: {rendetlensegSzint}");
            }
        }

        public void Szin()
        {
            if (szin == "narancssárga")
            {
                rendetlensegSzint = 100;
                Console.WriteLine($"Amiért narancssárag ezért autómatikusan {rendetlensegSzint} lesz a rendetlenségi szintje");
            }

        }

        public void fajtaJellegzetességek()
        {
            if (fajta ==  "Szfinx")
            {
                szin = "kopasz";
                Console.WriteLine($"Mivel a macska {fajta} fajtájú ezért ilyen színű: {szin}");
            }
            else if (fajta == "Maine Coon")
            {
                suly += 5;
                rendetlensegSzint -= 5;
                Console.WriteLine($"Mivel a macska {fajta} fajtájú ezért ezek lesznek rá jellemzőek súly: {suly} és rendetlenségi szint: {rendetlensegSzint}");
            }
            else if (fajta == "Bengáli")
            {
                rendetlensegSzint += 10;
                Console.WriteLine($"Mivel a macska {fajta} fajtájú ezért ezek lesznek rá jellemzőek rendetlenségi szintje: {rendetlensegSzint}");
            }
        }

        public override string? ToString()
        {
            return $"A cica neve: {nev} / kora: {kor} / súlya: {suly} / fajtája: {fajta} / színe: {szin} / rendetlenségi szintje (0-100): {rendetlensegSzint} / mennyire drága fenn tartani (0-10): {fogyasztas} / neme: {nem} / éhes-e (true / false): {ehes} ";
        }
    }
    }
