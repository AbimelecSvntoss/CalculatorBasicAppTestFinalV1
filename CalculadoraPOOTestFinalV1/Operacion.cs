using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraPOOTestFinalV1;

public abstract class Operacion
{
    public string Nombre { get; protected set; } = "";
    public abstract double Calcular(double n1, double n2);
    public virtual string Validar(double n1, double n2)
    {
        return "";
    }
}