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

        private double deskWidth;
        private double deskDepth;
        private int numDrawers;
        private string surfaceMaterial;
        private int rushOption;

        public Desk(double userWidth, double userDepth, int userDrawers, string userMaterial, int userRushOption)
        {
            deskWidth = userWidth;
            deskDepth = userDepth;
            numDrawers = userDrawers;
            surfaceMaterial = userMaterial;
            rushOption = userRushOption;
        }

        enum SurfaceMaterials
        {
            Laminate = 0,
            Oak = 1,
            Rosewood = 2,
            Veneer = 3,
            Pine = 4
        }
    }
}
