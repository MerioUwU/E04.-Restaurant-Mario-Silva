using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comanda
{
    class BaseDatos
    {
        public List<Menu> Listamenu { get; private set; }
        public List<Aperitivo> ListAperitivos { get; private set; }
        public List<Ensalada> ListEnsalada { get; private set; }
        public List<Carne> ListCarnes { get; private set; }
        public List<Pescado> ListPescado { get; private set; }
        public List<Pollo> ListPollo { get; private set; }
        public List<Pasta> ListPasta { get; private set; }
        public List<Sandwich> ListSandwich { get; private set; }
        public List<Panini> ListPaninis { get; private set; }
        public List<Postre> ListPostre { get; private set; }
        public List<Bebida> ListBebida { get; private set; }
        public List<Empty> Vacio { get; private set; }



        public BaseDatos()
        {
            Listamenu = new List<Menu>();
            ConstruirMenu();
        }

        private void ConstruirMenu()
        {
            Listamenu = new List<Menu>
            {   new Menu{Id=0,Nombre="None"},
                new Menu {Id = 1, Nombre = "Aperitivos"},
                new Menu {Id = 2, Nombre = "Ensalada"},
                new Menu {Id = 3, Nombre = "Carne"},
                new Menu {Id = 4, Nombre = "Pescado"},
                new Menu {Id = 5, Nombre = "Pollo"},
                new Menu {Id = 6, Nombre = "Pasta"},
                new Menu {Id = 7, Nombre = "Sandwichs"},
                new Menu {Id = 8, Nombre = "Paninis"},
                new Menu {Id = 9, Nombre = "Postre"},
                new Menu {Id = 10, Nombre = "Bebidas"}                          
            };

            ListEnsalada = new List<Ensalada> 
            {
             new Ensalada{Id=0,Nombre="None"},
             new Ensalada{Id=1,Nombre="Primavera"},
             new Ensalada{Id=2,Nombre="Clasica"},
             new Ensalada{Id=3,Nombre="Delizioso"},
             new Ensalada{Id=4,Nombre="Caesar con Pollo"},
             new Ensalada{Id=5,Nombre="Rustica con Camaron"},
             new Ensalada{Id=6,Nombre="Caprese"}
            
            };

            ListAperitivos = new List<Aperitivo>
            {
                new Aperitivo {Id=0,Nombre="None"},
                new Aperitivo {Id =1 , Nombre = "Calamar frito"}, 
                new Aperitivo {Id =2 , Nombre = "Plato siciliano"}, 
                new Aperitivo {Id =3 , Nombre = "Antipasti delizioso"},
                new Aperitivo {Id =4 , Nombre = "Fonduta Ahumada"},
                new Aperitivo {Id =5 , Nombre = "Mini albondigas delizioso"},
                new Aperitivo {Id =6 , Nombre = "Zuppa"},
                new Aperitivo {Id =7 , Nombre = "Crostini delizioso"},
                new Aperitivo {Id =8 , Nombre = "Champinones rellenos"},
            };

            ListCarnes = new List<Carne>
            {   new Carne {Id =0 , Nombre="None"},
                new Carne {Id =1 , Nombre = "Filete de la casa"},
                new Carne {Id =2 , Nombre = "Filete Mignon"},
                new Carne {Id =3 , Nombre = "Milanesa de Res Rellena"}
            };

            ListPescado = new List<Pescado>
            {
                new Pescado {Id =0 , Nombre="None"},
                new Pescado {Id =2 , Nombre = "Salmon"},
                new Pescado {Id =3 , Nombre = "Risoto con camaron"},
                new Pescado {Id =4 , Nombre = "Mar Delizioso"},
                new Pescado {Id =5 , Nombre = "Tilapia parmesana"},
                new Pescado {Id =6 , Nombre = "Croquetas de cangrejo"},
                new Pescado {Id =7 , Nombre = "Ceviche"}
            };

            ListPollo = new List<Pollo>
            {
                new Pollo {Id = 0 , Nombre = "None"},
                new Pollo {Id =1 , Nombre = "Marsala"},
                new Pollo {Id =2 , Nombre = "Rostizado en hierbas"},
                new Pollo {Id =3 , Nombre = "Parmigiana"},
                new Pollo {Id =4 , Nombre = "Picatta"},
                new Pollo {Id =5 , Nombre = "Pechuga de pollo rellena"},
            };
            ListPasta = new List<Pasta>
            {
                new Pasta {Id = 0 , Nombre = "None"},
                new Pasta {Id = 1 ,  Nombre = "Spaguetti a la putanesca"},
                new Pasta {Id =2,  Nombre = "Spaguetti clasico"},
                new Pasta {Id =3 ,  Nombre = "Pasta bolognesa"},
                new Pasta {Id =4 ,  Nombre = "Pasta al beto"},
                new Pasta {Id =5 ,  Nombre = "Delizioso pasta"},
                new Pasta {Id =6 ,  Nombre = "Pasta nana lucia"},
                new Pasta {Id =7 ,  Nombre = "Pasta pescatore"},
                new Pasta {Id =8 ,  Nombre = "Pasta al marco"},
                new Pasta {Id =9 ,  Nombre = "Pasta al roy"},
                new Pasta {Id =10 ,  Nombre = "Alfredo fetuccine con pollo"},
                new Pasta {Id =11 , Nombre  = "Raviolis"},
                new Pasta {Id =12 , Nombre  = "Pasta al cuore"},
                new Pasta {Id =13 , Nombre  = "Lasagna"},
                new Pasta {Id =14 , Nombre  = "Raviolis portobello"},
                new Pasta {Id =15 , Nombre  = "Rigatoni Delizioso"},
                new Pasta {Id =16 , Nombre  = "Trio delizioso"}
            };
            ListSandwich = new List<Sandwich>
            {
                new Sandwich{Id = 0 , Nombre = "None"},
                new Sandwich {Id =1 , Nombre = "De albondiga italiana"},
                new Sandwich {Id =2 , Nombre = "Atun fonduta"},
                new Sandwich {Id =3 , Nombre = "Clasico B.L.T."},
                new Sandwich {Id =4 , Nombre = "Pavo pesto"},
                new Sandwich {Id =5 , Nombre = "pastrami fonduta"},
                new Sandwich {Id =6 , Nombre = "De salchicha italiana"}
            };
            ListPaninis = new List<Panini>
            {
                new Panini {Id = 0 , Nombre = "None"},
                new Panini {Id =1 , Nombre = "Panini de pollo"},
                new Panini {Id =3 , Nombre = "Panini vegetariano"},
                new Panini {Id =4 , Nombre = "Panini rosat beef"},
                new Panini {Id =5 , Nombre = "Panini jamon"},
                new Panini {Id =6 , Nombre = "Panini salami"},
                new Panini {Id =7 , Nombre = "Panini pastramia"},
            };
            ListPostre = new List<Postre>
            {
                new Postre {Id = 0 , Nombre = "None"},
                new Postre {Id =1 , Nombre = "Cannoli"},
                new Postre {Id =2 , Nombre = "Tirasumi"},
                new Postre {Id =3 , Nombre = "Pastel de zanaoria"},
                new Postre {Id =4 , Nombre = "Gellato"},
                new Postre {Id =5 , Nombre = "Creme brulee"},
                new Postre {Id =6 , Nombre = "Pay de queso"},
                new Postre {Id =7 , Nombre = "Brownies"},
            };
            ListBebida = new List<Bebida>
            {
                new Bebida {Id = 0 , Nombre = "None"},
                new Bebida {Id =1 , Nombre = "Sodas"},
                new Bebida {Id =2 , Nombre = "Agua mineral"},
                new Bebida {Id =3 , Nombre = "Sangria preparada"},
                new Bebida {Id =4 , Nombre = "Jugo de naranja"},
                new Bebida {Id =5 , Nombre = "Jugo de manzana"},
                new Bebida {Id =6 , Nombre = "Te helado"},
                new Bebida {Id =7 , Nombre = "Limonada"},
                new Bebida {Id =8 , Nombre = "Cafe"},
                new Bebida {Id =9 , Nombre = "Te caliente"},
                new Bebida {Id =10 , Nombre = "Vino"},
                new Bebida {Id =11 ,Nombre = "Cerveza"},
            };

            Vacio = new List<Empty>
            {
                new Empty {ID =0 , Nombre = "Nombre"},
              
            };


        }
        }
       }

