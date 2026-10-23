using System;
using System.Globalization;

namespace S4_Compra
{
    public static class CalculadoraCompra
    {
        public const decimal TasaIva = 0.15m;

        public static (decimal Subtotal, decimal Descuento, decimal Iva, decimal Total)
            Calcular(decimal precio, int cantidad)
        {
            decimal subtotal = precio * cantidad;
            decimal descuento = 0m;

            if (subtotal >= 100m)
            {
                descuento = Math.Round(
                    subtotal * 0.10m, 2,
                    MidpointRounding.AwayFromZero);
            }

            decimal iva = Math.Round(
                (subtotal - descuento) * TasaIva,
                2,
                MidpointRounding.AwayFromZero);

            decimal total = subtotal - descuento + iva;

            return (subtotal, descuento, iva, total);
        }

        public static string Dinero(decimal valor)
        {
            return "$" + valor.ToString(
                "F2", CultureInfo.InvariantCulture);
        }
    }
}