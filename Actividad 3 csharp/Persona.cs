using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

internal class Persona
{
    protected string nombre;
    protected DateTime? fechaDenacimiento;


    public string Nombre
    {
        get
        {
            return nombre;
        }
        set
        {
            nombre = value;
        }
    }
    public DateTime? FechaDenacimiento
    {
        get
        {
            return fechaDenacimiento;
        }
        set
        {
            fechaDenacimiento = value;
        }
    }
    public int Edad
    {
        get
        {
            int Edad_;
            Edad_ = (DateTime.Now.Year - fechaDenacimiento.Value.Year);
            return Edad_;
        }
    }
    public Persona()
    {
        Nombre = "";
        fechaDenacimiento = null;
    }
    public Persona(string nombre_, DateTime? FechaDenacimento)
    {
        this.nombre = Nombre;
        this.fechaDenacimiento = FechaDenacimento;

    }

    public override string ToString()
    {
        return Nombre.ToUpper() + " " + Edad;
    }


}