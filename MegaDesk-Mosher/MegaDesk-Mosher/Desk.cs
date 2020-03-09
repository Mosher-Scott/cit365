using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Mosher
{
    class Desk
    {
        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 12;
        public const int MAXDEPTH = 48;

        public const int MINDRAWERS = 0;
        public const int MAXDRAWERS = 7;

        public const int BASEPRICE = 200;

        public double deskWidth;
        public double deskDepth;
        public int numDrawers;
        public string surfaceMaterial;
        public int rushOption;

        public Desk(double userWidth, double userDepth, int userDrawers, string userMaterial, int userRushOption)
        {
            deskWidth = userWidth;
            deskDepth = userDepth;
            numDrawers = userDrawers;
            surfaceMaterial = userMaterial;
            rushOption = userRushOption;
        }

        public enum SurfaceMaterials
        {
            Laminate = 100,
            Oak = 200,
            Rosewood = 300,
            Veneer = 125,
            Pine = 50
        }

        // Calculates the entire surface area
        public double getDeskSurfaceArea()
        {
            return this.deskWidth * this.deskDepth;
        }

        // Returns the cost above the base price if the surface area is greater than 1000 sq in
        public double getSurfaceAreaCost()
        {
            double cost = 0;
            double surfaceArea = getDeskSurfaceArea(); 

            if (surfaceArea > 1000)
            {
                cost = surfaceArea - 1000;
            }

            return cost;
        }

        // Returns the cost of drawers, based on how many the client orders
        public double getDrawerCost()
        {
            return this.numDrawers * 50;
        }

        // Gets the cost of the surface materials the client wants
        public double getSurfaceMaterialCost()
        {
            double cost = 0;

            switch (this.surfaceMaterial)
            {
                case "Oak":
                    cost = (int)SurfaceMaterials.Oak;
                    break;

                case "Laminate":
                    cost = (int)SurfaceMaterials.Laminate;
                    break;

                case "Pine":
                    cost = (int)SurfaceMaterials.Pine;
                    break;

                case "Rosewood":
                    cost = (int)SurfaceMaterials.Rosewood;
                    break;

                case "Veneer":
                    cost = (int)SurfaceMaterials.Veneer;
                    break;
            }

            return cost;
        }

        // Gets the rush order options based on desk size
        public double getRushOrderPrice()
        {
            double price = 0;
            double surfaceArea = getDeskSurfaceArea();

            if (surfaceArea < 1000)
            {
                if (this.rushOption == 3)
                {
                    price = 60;
                } else if (this.rushOption == 5)
                {
                    price = 40;
                } else if (this.rushOption == 7)
                {
                    price = 30;
                }
            }

            else if (surfaceArea > 1000 && surfaceArea < 2000)
            {
                if (this.rushOption == 3)
                {
                    price = 70;
                }
                else if (this.rushOption == 5)
                {
                    price = 50;
                }
                else if (this.rushOption == 7)
                {
                    price = 35;
                }
            }

            else
            {
                if (this.rushOption == 3)
                {
                    price = 80;
                }
                else if (this.rushOption == 5)
                {
                    price = 60;
                }
                else if (this.rushOption == 7)
                {
                    price = 40;
                }
            }

            return price;
        }

        public double getTotalCost()
        {
            return Desk.BASEPRICE + this.getSurfaceAreaCost() + this.getDrawerCost() + this.getSurfaceMaterialCost() + this.getRushOrderPrice();
        }
    }
}
