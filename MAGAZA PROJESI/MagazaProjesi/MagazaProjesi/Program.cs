using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagazaProjesi
{

    class Program
    {

        static void Main(string[] args)
        {

            Product product = new Product();

            Load(product);
        }

        private static void Load(Product product)
        {
            string secim = "";


            Console.WriteLine("Dogru secim edin");

            Console.WriteLine("*******************************************CakeCook sirinler magazasina xos gelmisiniz*******************************************\n\n\n");
            Console.WriteLine("=============================================");
            Console.WriteLine("== 1.Mehsullar uzerinde emeliyyat aparmaq. ==");
            Console.WriteLine("== 2.Satislar uzerinde emeliyyat aparmaq.  ==");
            Console.WriteLine("== 3.Sistemden cixmaq.                     ==");
            Console.WriteLine("=============================================");


            Console.WriteLine("Seciminizi daxil edin");
            secim = Console.ReadLine();


            switch (secim)
            {
                case "1":
                    Console.WriteLine("1.1Yeni mehsul elave et:");
                    Console.WriteLine("1.2.Mehsulun uzerinde duzelis et:");
                    Console.WriteLine("1.3.Mehsulu silL:");
                    Console.WriteLine("1.4.Butun mehsullari goster:");
                    Console.WriteLine("1.5.Kateqoriyasina gore mehsullari goster");
                    Console.WriteLine("1.6.Qiymet araligina gore mehsullari goster:");
                    Console.WriteLine("1.7.Mehsullar arasinda ada gore axtaris et:");

                    Console.WriteLine("Seciminizi daxil edin");
                    secim = Console.ReadLine();

                    break;
                case "2":
                    Console.WriteLine("2.1.Yeni satis elave etmek:");
                    Console.WriteLine("2.2.Mehsulun satisdan cixarilmasi:");
                    Console.WriteLine("2.3.Satisin silinmesi:");
                    Console.WriteLine("2.4.Butun satislarin ekrana cixarilmasi:");
                    Console.WriteLine("2.5.Verilen tarix araligina gore satislarin gosterilmesi :");
                    Console.WriteLine("2.6.Verilen mebleg araligina gore satislarin gosterilmesi :");
                    Console.WriteLine("2.7.Verilmis bir tarixde olan satislarin gosterilmesi:  ");
                    Console.WriteLine("2.8 Verilmis nomreye esasen hemin nomreli satisin melumatlarinin gosterilmesi :");

                    Console.WriteLine("Seciminizi daxil edin");
                    secim = Console.ReadLine();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    {
                        Load(null);

                        break;
                    }
            }



            switch (secim)
            {
                case "1.1":
                    {
                        string code, name;
                        float price, count;
                        Category category;
                        Console.WriteLine("Mehsul kodunu daxil edin");
                        code = Console.ReadLine();
                        Console.WriteLine("Mehsul adini daxil edin");
                        name = Console.ReadLine();
                        Console.WriteLine("Mehsul qiymetini daxil edin");
                        price = float.Parse(Console.ReadLine());
                        Console.WriteLine("Mehsul sayini daxil edin");
                        count = float.Parse(Console.ReadLine());
                        Console.WriteLine("Kategoriyasini daxil edin");
                        Console.WriteLine("0- Tortlar");
                        Console.WriteLine("1- Sirin un memulatlari");
                        Console.WriteLine("2- Eklerler");
                        Console.WriteLine("3- Milli sirniyyatlar");
                        Console.WriteLine("4-Pirojnalar");

                        category = (Category)int.Parse(Console.ReadLine());


                        product.AddNewProduct(code, name, price, count, category);

                        Load(product);
                        Console.WriteLine("Yeni sirniyyat bilgileri stoka elave edildi");
                        break;
                    }
                case "1.2":
                    {

                        Console.WriteLine("1.2.1. Mehsulda umumi deyisiklik aparmaq:");
                        Console.WriteLine("1.2.2. Mehsulun adini deyismek");
                        Console.WriteLine("1.2.3. Mehsulun qiymetini deyismek");
                        Console.WriteLine("1.2.4.Mehsulun sayini deyismek");
                        Console.WriteLine("1.2.5.Mehsulun kateqoriyasini deyismek");
                        Console.WriteLine("Seciminizi daxil edin");
                        secim = Console.ReadLine();
                        break;
                    }

                case "1.3":
                    {
                        string code;

                        Console.WriteLine("Silinecek kodunu daxil edin");
                        code = Console.ReadLine();

                        product.RemoveProductbyCode(code);
                        Load(product);
                        break;
                    }
                case "1.4":
                    {
                        product.Products.ForEach(prod =>
                        {
                            Console.WriteLine(prod.codeProduct + " " + prod.NameProduct + " " + prod.PriceProduct + " " + prod.countProduct + " " + prod.category);

                        });
                        Console.ReadLine();
                        Load(product);
                        break;

                    }
                case ("1.5"):
                    {
                        Console.WriteLine("Tapmaq istediyiniz kateqoriyani daxil edin");
                        Console.WriteLine("0- Tortlar");
                        Console.WriteLine("1- Sirin un memulatlari");
                        Console.WriteLine("2- Eklerler");
                        Console.WriteLine("3- Milli sirniyyatlar");
                        Console.WriteLine("4- Pirojnalar");

                        Category cate = ((Category)int.Parse(Console.ReadLine()));



                        product.Products.ForEach(prod =>
                        {
                            if (prod.category == cate)
                                Console.WriteLine(prod.codeProduct + " " + prod.NameProduct + " " + prod.PriceProduct + " " + prod.countProduct + " " + prod.category);

                        });
                        Console.ReadLine();
                        Load(product);

                    }
                    break;

                case ("1.6"):
                    {
                        Console.WriteLine("Gostermek istediyiniz mehsullarin qiymetlerin daxil edin");
                        float FirstPrice = float.Parse(Console.ReadLine());
                        float SecondPrice = float.Parse(Console.ReadLine());

                        product.Products.ForEach(prod =>
                        {
                            if (prod.PriceProduct >= FirstPrice && prod.PriceProduct <= SecondPrice)
                                Console.WriteLine(prod.codeProduct + " " + prod.NameProduct + " " + prod.PriceProduct + " " + prod.countProduct + " " + prod.category);

                        });
                        Console.ReadLine();
                        Load(product);
                    }
                    break;
                case "1.7":
                    {
                        Console.WriteLine("Tapmaq istediyiniz mehsulun adin daxil edin");
                        string search = Console.ReadLine();
                        search = search.ToLower();

                        product.Products.ForEach(prod =>
                        {
                            if (prod.NameProduct.ToLower().Contains(search))
                                Console.WriteLine(prod.codeProduct + " " + prod.NameProduct + " " + prod.PriceProduct + " " + prod.countProduct + " " + prod.category);

                        });
                        Console.ReadLine();
                        Load(product);

                        break;
                    }
            }
            switch (secim)
            {
                case ("1.2.1"):
                    {

                        string code, name;
                        float price, count;
                        Category category;
                        Console.WriteLine("Mal kodunu daxil edin");
                        code = Console.ReadLine();
                        Console.WriteLine("Yeni Mal adini daxil edin");
                        name = Console.ReadLine();
                        Console.WriteLine("Yeni Mal qiymetini daxil edin");
                        price = float.Parse(Console.ReadLine());
                        Console.WriteLine("Yeni Mal qaligini daxil edin");
                        count = float.Parse(Console.ReadLine());
                        Console.WriteLine("Yeni Kategoriyasini daxil edin");
                        Console.WriteLine("0- Et mehsullari");
                        Console.WriteLine("1- Sud mehsullari");
                        Console.WriteLine("2- Un mehsullari");
                        Console.WriteLine("3- Terevez mehsullari");

                        category = (Category)int.Parse(Console.ReadLine());

                        product.ChangeProductbyCode(code, name, price, count, category);
                        Load(product);
                    }
                    break;
                case "1.2.2":
                    {
                        Console.WriteLine("Deyiseceyiniz mehsulun codunu daxil edin");
                        string cod = Console.ReadLine();
                        if (product.Products.Exists(p => p.codeProduct == cod))
                        {
                            Console.WriteLine("Yeni adi daxil edin: ");
                            string name = Console.ReadLine();
                            product.ChangeProductName(cod, name);
                            Console.WriteLine("Ad deyisildi:", product.ChangeName(cod));
                        }
                        else
                        {
                            Console.WriteLine("Daxil etdiyiniz koda mexsus mehsul yoxdur");
                        }
                        Load(product);
                    }
                    break;
                case ("1.2.3"):
                    {
                        Console.WriteLine("Deyiseceyiniz mehsulun codunu daxil edin");
                        string cod = Console.ReadLine();
                        if (product.Products.Exists(p => p.codeProduct == cod))
                        {
                            Console.WriteLine("Yeni qiymeti daxil edin: ");
                            float price = float.Parse(Console.ReadLine());
                            product.ChangeProductPrice(cod, price);
                            Console.WriteLine("Mehsulun qiymeti deyisildi:", product.ChangePrice(cod));
                        }
                        else
                        {
                            Console.WriteLine("Daxil etdiyiniz koda mexsus mehsul yoxdur");
                        }
                    }
                    Load(product);
                    break;
                case ("1.2.4"):
                    {
                        Console.WriteLine("Deyiseceyiniz mehsulun codunu daxil edin");
                        string cod = Console.ReadLine();
                        if (product.Products.Exists(p => p.codeProduct == cod))
                        {
                            Console.WriteLine("Yeni sayi daxil edin: ");
                            float count = float.Parse(Console.ReadLine());
                            product.ChangeProductCount(cod, count);
                            Console.WriteLine("Mehsulun sayi deyisildi:", product.ChangeCount(cod));
                        }
                        else
                        {
                            Console.WriteLine("Daxil etdiyiniz koda mexsus mehsul yoxdur");
                        }
                        Load(product);
                    }
                    break;
                case ("1.2.5"):
                    {
                        Console.WriteLine("Deyiseceyiniz mehsulun codunu daxil edin");
                        string cod = Console.ReadLine();
                        if (product.Products.Exists(p => p.codeProduct == cod))
                        {
                            Console.WriteLine("Yeni kateqoriyani daxil edin: ");
                            Category category = (Category)int.Parse(Console.ReadLine());
                            product.ChangeProductCategory(cod, category);
                            Console.WriteLine("Mehsulun sayi deyisildi:", product.ChangeCategory(cod));
                        }
                        else
                        {
                            Console.WriteLine("Daxil etdiyiniz koda mexsus mehsul yoxdur");
                        }
                        Load(product);
                    }
                    break;
            }
            switch (secim)
            {
                case ("2.1"):
                    {
                        int no, count;
                        Product product1;
                        Console.WriteLine("Mehsulun kodunu daxil edin");
                        string cod = Console.ReadLine();
                        if (product.Products.Exists(p => p.codeProduct == cod))
                        {
                            Console.WriteLine("Bu produktun satis sayini daxil edin");
                            count = Convert.ToInt32(Console.ReadLine());
                            product.Addsale(product, count);
                            Load(product);
                        }
                        else
                        {
                            Console.WriteLine("Daxil etdiyiniz koda mexsus stokda mehsul yoxdur.\n Melumatlari duzgun yazdiginizdan emin olun");
                        }

                    }
                    break;
            }
        }
    }
}