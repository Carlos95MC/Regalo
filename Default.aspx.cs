using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class _Default : Page
    {
        ListItem listItem;
                
        decimal precio;
        int count1 = 0;
        int count2 = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (ddlLista.Items.Count == 0)
            {
                listItem = new ListItem("Favoritos", "1");
                ddlLista.Items.Add(listItem);
                listItem = new ListItem("Carrito", "2");
                ddlLista.Items.Add(listItem);
            }
        }
        protected void Agregar_Click(Object sender, EventArgs e)
        {
            if (ddlLista.SelectedValue.Equals("1"))
            {
                if(lbFavoritos.Text.Equals(""))
                    lbFavoritos.Text =  idNombreProducto.Text + " " + idPrecio.Text+ "€";
                else
                    lbFavoritos.Text = lbFavoritos.Text + ", " + idNombreProducto.Text + " " + idPrecio.Text + "€";
                count1++;

            }
            if (ddlLista.SelectedValue.Equals("2"))
            {
                if (lbCarrito.Text.Equals(""))
                    lbCarrito.Text = idCantidad.Text + " X " + idNombreProducto.Text +" "+ idPrecio.Text + "€" + " Subtotal item: " + decimal.Parse(idPrecio.Text) * decimal.Parse(idCantidad.Text) + "€";
                else
                    lbCarrito.Text = lbCarrito.Text + ", " + idCantidad.Text + " X " + idNombreProducto.Text + " " + idPrecio.Text + "€" + " Subtotal item: " + decimal.Parse(idPrecio.Text) * decimal.Parse(idCantidad.Text) + "€";
                count2++;

                precio = precio + (decimal.Parse(idPrecio.Text) * decimal.Parse(idCantidad.Text));
                sumaSubtotal.Text = precio + "€";
            }
           
        }
    }
}