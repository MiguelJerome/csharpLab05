using System.ComponentModel;
using System.Runtime.CompilerServices;

class Point
    {

        public int VerifierIntervalle(int plageValeur)
        {
            const int INTERVALEL_MAX = 10;
            const int INTERVALLE_MIN = -10;
            const int EN_DEHORS_INTERVALLE = 0;

            if (plageValeur < INTERVALLE_MIN && plageValeur > INTERVALEL_MAX)
            {
                return EN_DEHORS_INTERVALLE;
            }

            return plageValeur;
        }
        public Point()
        {
            this._abcisse = 1;
            this._ordonne = 1;
        }

        public Point(int abcisse)
        {
            this._abcisse = this.VerifierIntervalle(abcisse);
            this._ordonne = 1;
        }

        public Point(int abcisse, int ordonne)
        {
            this._abcisse = this.VerifierIntervalle(abcisse);
            this._ordonne = this.VerifierIntervalle(ordonne);
        }

        public String ToString()
        {
            String stringPoint = "[Abcisse = " + this._abcisse + ", Ordonne = " + this._ordonne + "]";
            return stringPoint;

        }

        public void Translater(int vx, int vy)
        {
            this._abcisse += vx;
            this._ordonne += vy;
        }

        public double Distance(Point p)
        {
            return Math.Sqrt( Math.Pow((this._abcisse - p._abcisse),2) + Math.Pow((this._ordonne-p._ordonne),2));
        }

        public double Distance(int abcisse, int ordonne)
        {
            Point p = new Point(abcisse, ordonne);
            p._ordonne = p.VerifierIntervalle(ordonne);
            p._abcisse =p.VerifierIntervalle(abcisse);
            return Math.Sqrt(Math.Pow((this._abcisse - p._abcisse), 2) + Math.Pow((this._ordonne - p._ordonne), 2));
        }
     
        public void Egualite(Point p)
        {
            if (this._ordonne == p._ordonne && this._abcisse == p._abcisse)
            {
                Console.WriteLine($"Les deux points sont egaux");
            }
            else
            {
                Console.WriteLine($"Les deux employes ne sont pas");
            }

        }

        public int Abcisse
        {
            get { return this._abcisse; } // read
            set
            {  
                _abcisse = this.VerifierIntervalle(value); // write
            }

        }

        public int Ordonne
        {
            get { return this._ordonne; } // read
            set
            {
                 _ordonne = this.VerifierIntervalle(value); // write
            }

    }




        private int _abcisse;
        private int _ordonne;
    }

        
