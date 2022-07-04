using System.Net.NetworkInformation;
using System.Security.Cryptography;

class Rectangle
{

    public Rectangle(Point p1, Point p2, Point p3, Point p4)
    {
        this._p1.Egualite(p1); 
        this._p2.Egualite(p2);
        this._p3.Egualite(p3);
        this._p4.Egualite(p4);
    }

    public Rectangle(int x1Sommet1, int y1Sommet1, int x2Sommet2, int y2Sommet2)
    { 
        
        
        //setter le premier point du rectangle p1
        this._p1.Abcisse = x1Sommet1;
        this._p1.Ordonne = y1Sommet1;

        //setter le premier point du rectangle p2
        this._p2.Abcisse = x2Sommet2;
        this._p2.Ordonne = y1Sommet1;

        //setter le premier point du rectangle p3
        this._p3.Abcisse = x1Sommet1;
        this._p3.Ordonne = y2Sommet2;

            // setter le quatrieme point du rectangle p4
        this._p4.Abcisse = x2Sommet2;
        this._p4.Ordonne = y2Sommet2;
    }

    public double Largeur()
    {
        return this._p1.Distance(this._p2);
    }

    public double Hauteur()
    {
        return this._p2.Distance(this._p4);
    }
    public double Perimetre()
    {
        const int DEUX_COTES_PAREIL = 2;
        return (this.Largeur() * DEUX_COTES_PAREIL) + (this.Hauteur() * DEUX_COTES_PAREIL);
    }

    public double Surface()
    {
        return this.Largeur() * this.Hauteur();
    }

    public String ToString()
    {
        String stringP1 = "[Abscisse = " + this._p1.Abcisse + ", Ordonne = " + this._p1.Ordonne + "],";
        String stringP2 = "[Abscisse = " + this._p2.Abcisse + ", Ordonne = " + this._p2.Ordonne + "],";
        String stringP3 = "[Abscisse = " + this._p3.Abcisse + ", Ordonne = " + this._p3.Ordonne + "],";
        String stringP4 = "[Abscisse = " + this._p4.Abcisse + ", Ordonne = " + this._p4.Ordonne + "]";

        String stringRectangle = "Rectangle : " + stringP1 + stringP2 + stringP3 + stringP4;
        return stringRectangle;
    }

    public Boolean Appartenir(Point p)
    {
        if (this.VerifierAbcisse(p) && this.VerifierOrdonne(p) )
        {
            return true;
        }
        return false;

    }

    public Boolean VerifierAbcisse(Point p)
    {
        if (!(p.Abcisse < this._p1.Abcisse && p.Abcisse > this._p2.Abcisse))
        {
            return true;
        }

        return false;
    }

    public Boolean VerifierOrdonne(Point p)
    {
        if (!(p.Ordonne < this._p1.Ordonne && p.Ordonne > this._p2.Ordonne))
        {
            return true;
        }

        return false;
    }

    public Boolean Appartenir(Rectangle rectangle)
    {
        Boolean coinRectanglep1 = false;
        Boolean coinRectanglep2 = false;
        Boolean coinRectanglep3 = false;
        Boolean coinRectanglep4 = false;

       

        // verifier le premiere coin p1 du rectangle si il est a l interieur du Rectangle main
        if (this.VerifierOrdonne(rectangle._p1) && this.VerifierAbcisse(rectangle._p1))
        {
            coinRectanglep1 = true;
            Console.WriteLine($"Est- que le coin p1 du Rectangle2 est a l interieur du Rectangle1 : {coinRectanglep1}");
        }
        else
        {
            Console.WriteLine($"Est- que le coin p1 du Rectangle2 est a l interieur du Rectangle1 : {coinRectanglep1}");
        }

        // verifier le deuxieme coin p2 du rectangle si il est a l interieur du Rectangle main
        if (this.VerifierOrdonne(rectangle._p2) && this.VerifierAbcisse(rectangle._p2))
        {
            coinRectanglep2 = true;
            Console.WriteLine($"Est- que le coin p2 du Rectangle2 est a l interieur du Rectangle1 : {coinRectanglep2}");
        }
        else
        {
            Console.WriteLine($"Est- que le coin p2 du Rectangle2 est a l interieur du Rectangle1  : {coinRectanglep2}");
        }

        // verifier le troisieme coin p3 du rectangle si il est a l interieur du Rectangle main
        if (this.VerifierOrdonne(rectangle._p3) && this.VerifierAbcisse(rectangle._p3))
        {
            coinRectanglep3 = true;
            Console.WriteLine($"Est- que le coin p3 du Rectangle2 est a l interieur du Rectangle1  : {coinRectanglep3}");
        }
        else
        {
            Console.WriteLine($"Est- que le coin p3 du Rectangle2 est a l interieur du Rectangle1  : {coinRectanglep3}");
        }

        // verifier le quatrieme coin p4 du rectangle si il est a l interieur du Rectangle main
        if (this.VerifierOrdonne(rectangle._p4) && this.VerifierAbcisse(rectangle._p4))
        {
            coinRectanglep4 = true;
            Console.WriteLine($"Est- que le coin p4 du Rectangle2 est a l interieur du Rectangle1  : {coinRectanglep4}");
        }
        else
        {
            Console.WriteLine($"Est- que le coin p4 du Rectangle2 est a l interieur du Rectangle1  : {coinRectanglep4}");
        }

        if (coinRectanglep1 && coinRectanglep2 && coinRectanglep3 && coinRectanglep4)
        {
            return true;

        }

        return false;

    }

    private Point _p1 = new Point();
    private Point _p2 = new Point();
    private Point _p3 = new Point();
    private Point _p4 = new Point();
}