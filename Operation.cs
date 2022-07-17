using System;
using System.Collections.Generic;

namespace ToDo
{
    public class Operation
    {
        Cards cards=new Cards();
        Person person=new Person();

        public void DefaultPerson()
        {
            person.Add("1","Emre","Başpınar");
            person.Add("2","Ali","İhsan");
        }
        public void DefaultCard()
        {
            cards.Add("Papara","Sanala kart","1","2");
            cards.Add("İninal","Sanal Kart","2","3");
        }
        public void LetsGo()
        {
            Console.WriteLine(" Lütfen yapmak istediğiniz işlemi seçiniz :) ");    
            Console.WriteLine(" *******************************************");    
            Console.WriteLine(" (1) Board Listelemek");    
            Console.WriteLine(" (2) Board'a Kart Eklemek");    
            Console.WriteLine(" (3) Board'dan Kart Silmek");    
            Console.WriteLine(" (4) Kart Taşımak");    
            Console.WriteLine(" (5) Programı Kapat");  
        }
        public void Add()
        {
            Console.WriteLine("Card Ekleme Noktası");
            Console.WriteLine("****************************************");
            Console.Write("Kart Başlığı Giriniz");
            string header=Console.ReadLine();
            Console.Write("Kart Başlığı Giriniz");
            string content=Console.ReadLine();
            i:
            Console.Write("Kart Başlığı Giriniz");
            string id=Console.ReadLine();
            if (!person.ItsHave(id))
            {
                Console.WriteLine("Yanlış Bir Id Girdiniz");
                goto i;
            }
            b:
            Console.Write("Kart Büyüklüğünü Giriniz --> XS(1),S(2),M(3),L(4),XL(5) : ");
            string size=Console.ReadLine();
            if (int.Parse(size)<1 || int.Parse(size)>5 )
            {
                Console.WriteLine("Yanlış Bir Büyüklük Seçtiniz Lütfen Standartlara Uyunuz");
                goto b;
            }
            cards.Add(header,content,id,size);
            Console.WriteLine("İşlem Başarılı :)");
        }
        public void GetList()
        {
            List<CardModel> list = cards.List();
             Console.WriteLine("Kartları Görüntüleme Bölümü");
            Console.WriteLine("*******************************************");
            Console.WriteLine("TODO Line");
            Console.WriteLine("*******************************************");
            foreach (var lister in list)
            {
                if (lister.Situation == 0)
                {
                    Console.WriteLine("Başlık           = {0}",lister.Header);
                    Console.WriteLine("İçerik           = {0}",lister.Content);
                    Console.WriteLine("Kart sahibi      = {0}",person.Find(lister.AppointedPerson));
                    Console.WriteLine("Kart büyüklüğü   = {0}",(Sizes)int.Parse(lister.Grown));
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("IN PROGRESS Line");
            Console.WriteLine("*******************************************");
            foreach (var lister in list)
            {
                if (lister.Situation==1)
                {
                    Console.WriteLine("Başlık           = {0}",lister.Header);
                    Console.WriteLine("İçerik           = {0}",lister.Content);
                    Console.WriteLine("Kart Sahibi      = {0}",lister.AppointedPerson);
                    Console.WriteLine("Kart Büyüklüğü   = {0}",lister.Grown);
                }
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("DONE Line");
            Console.WriteLine("**********************************************");
            foreach (var lister in list)
            {
                if (lister.Situation==2)
                {
                    
                
                    Console.WriteLine("Başlık               = {0}",lister.Header);
                    Console.WriteLine("İçerik               = {0}",lister.Content);
                    Console.WriteLine("Kart Sahibi          = {0}",lister.AppointedPerson);
                    Console.WriteLine("Kart Büyüklüğü       = {0}",lister.Grown);
                }
            }
        }
        public void Delete()
        {
            List<CardModel> lists = new List<CardModel>();
            Console.WriteLine("Kart Silme Noktası");
            Console.WriteLine("**************************************");
            Console.WriteLine("Silmek istediğiniz kartın başlığını giriniz");
            string header=Console.ReadLine();
            lists=cards.Find(header,"","","");
            if (lists.Count<=0)
            {
                Console.WriteLine("Aradığınız Card Bulunamadı");
                Console.WriteLine("Tekrar Denemek için (1)");
                Console.WriteLine("İşlemi İptal Etmek için Herhangi bir tuşa basınız");
                string choice= Console.ReadLine();
                if (int.Parse(choice)==1)
                {
                    Delete();
                }
                else 
                {
                    Console.WriteLine("İşlem İptal Edilmiştir.");
                }
            }
            
            else
            {
                Console.WriteLine("{0} kart'ı Silmek İstiyor Musunuz y/n",lists[0].Header);
                string yn=Console.ReadLine();
                if (yn=="Y")
                {
                    
                }
                else
                {
                    Console.WriteLine("İşlem İptal Edildi");
                }
            }
        }
        public void MoveCard()
        {
            List<CardModel> lists = new List<CardModel>();
            Console.WriteLine("Kart Taşıma Bölümü");
            Console.WriteLine("*******************************************");
            Console.WriteLine("Taşımak istediğiniz kartın kart başlığını giriniz");
            string control=Console.ReadLine();
            lists=cards.Find(control,"","","");
            if (lists.Count<=0)
            {
                Console.WriteLine("Aradığınız Card Bulunamadı");
                Console.WriteLine("Tekrar Denemek İçin (1)");
                Console.WriteLine("İşlemi İptal etmek için Herhangi bir tuşa basınız");
                string number =Console.ReadLine();
                if (int.Parse(number) == 1)
                {
                    MoveCard();
                }
                else
                {
                    Console.WriteLine("İşlem İptal Edilmiştir İyi Günler");
                }
            }
            else
            {
                Console.WriteLine("Bulunan kart bilgiler");
                Console.WriteLine("*******************************************");
                foreach (var list in lists)
                {
                    Console.WriteLine("Başlık               = {0}",list.Header);
                    Console.WriteLine("İçerik               = {0}",list.Content);
                    Console.WriteLine("Kart sahibi          = {0}",list.AppointedPerson);
                    Console.WriteLine("Kart Büyüklüğü       = {0}",list.Grown);
                    Console.WriteLine("Durum                = {0}",list.Situation);
                    Console.WriteLine("****** ****** ****** ******");
                    l:
                    Console.WriteLine("Lütfen taşımak istediğiniz hattı seçiniz");
                    Console.WriteLine("(0) TODO");
                    Console.WriteLine("(1) IN PROGRESS");
                    Console.WriteLine("(2) DONE");
                    int choice=int.Parse(Console.ReadLine());
                    if (choice>2 || choice<0)
                    {
                        Console.WriteLine("Yanlış Büyüklük Seçtiniz");
                        goto l;
                    }
                    list.Situation = choice;
                }
            }
        }
    }
}