using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bissoweb.Library
{
    public class LPaginador<T>
    {
        //Cantidad de Resultados por pagina
        private int pagi_cuantos = 1;
        //Cantidad de Enlaces que se mostraran como maximo en la barra de navegacion
        private int pagi_nav_num_enlaces = 3;
        private int pagi_actual;
        //Definimos que ira en el enlace a la pagina anterior.
        private String pagi_nav_anterior = " &laquo; Anterior";
        //Definimos que ira en el enlace a la pagina Siguiente.
        private String pagi_nav_siguiente = " Siguiente &raquo";
        //Definimos que ira en el enlace a la primera y ultima pagina
        private String pagi_nav_primera = " &laquo; Primera";
        private String pagi_nav_ultima = " Ultima &raquo";
        private String pagi_navegacion = null;

        public object[] paginador(List<T> table, int pagina, int Registros, String area, String controller,
            String action, String host)
        {
            if (Registros > 0)
            {
                pagi_cuantos = Registros;
            }
            if (pagina.Equals(0))
            {
                //Si no  se hecho click a ninguna pagina especifica
                // o sea si es la primera vez que se ejecuta el script
                // pagi_actual es la pagina actual --> sera por defecto la primera.
                pagi_actual = 1;
            }
            else
            {
                // si se pidio una pagina especfica
                // la pagina actual es la que se selecciono.
                pagi_actual = pagina;
            }
            int pagi_totalReg = table.Count;
            int pagi_TotalRegs = pagi_totalReg;
            int resultadotrolo = pagi_totalReg % pagi_cuantos;
            if ((resultadotrolo) > 0)
            {
                pagi_TotalRegs += 2;
            }
            int pagi_totalPags = pagi_TotalRegs / pagi_cuantos;
            if (pagi_actual != 1)
             {
                // si no estamos en la pagina 1. Ponemos enlace primera
                int pagi_url = 1; // sera el numero de pagina al que enlazamos.
                pagi_navegacion += "<a class='btn btn-default' href='" + host + "/" + controller + "/" +
                    action + "?id=" + pagi_url + "&Registros=" + pagi_cuantos + "&area=" + area + "'>" + pagi_nav_primera + "</a>";
                    
                //si no estamos en la pagian 1. Ponemos enlace anteror.
                pagi_url = pagi_actual - 1;
                pagi_navegacion += "<a class='btn btn-default' href='" + host + "/" + controller + "/" +
                    action + "?id=" + pagi_url + "&Registros=" + pagi_cuantos + "&area=" + area + "'>" + pagi_nav_anterior + "</a>";
            }

            //si se definio la variable pagi_nav_num_enlaces
            //calculamos el intervalo para restar y sumar a partir de la pagina acutal.
            double valor2 = (pagi_nav_num_enlaces / 2);
            int pagi_nav_intervalo = Convert.ToInt16(Math.Round(valor2));
            // Calculamos desde que nro de pagina se mostrara
            int pagi_nav_desde = pagi_actual - pagi_nav_intervalo;
            //calculamos hasta que nro de pagina se mostrara.
            int pagi_nav_hasta = pagi_actual + pagi_nav_intervalo;
            //Si pagi_nav_desde es un nro negativo
            if (pagi_nav_desde < 1)
            {
                // le sumamos la cantidad sobrante al final para mantener 
                //el nro de enlaces que se quieren mostrar.
                pagi_nav_hasta -= (pagi_nav_desde - 1);
                // Establecemos pagi_nav_desde como 1
                pagi_nav_desde = 1;
            }
            //Si pagi_nav_hasta es mayor que el nro total de paginas que mostramos.
            if (pagi_nav_hasta > pagi_totalPags)
            {
                //Le restamos la cantidad excedida al comienzo para mantener 
                //el nro de enlaces que se quieren mostrar.
                pagi_nav_desde -= (pagi_nav_hasta - pagi_totalPags);
                //Establecemos pagi_nav_hasta con el total de paginas.
                pagi_nav_hasta = pagi_totalPags;
                //Hacemos el ultimo ajuste verificando que al cambiar pagi_nav_desde
                //no haya quedado con un valor no valido.
                if (pagi_nav_desde < 1)
                {
                    pagi_nav_desde = 1;
                }
            }
            for (int pagi_i = pagi_nav_desde; pagi_i <= pagi_nav_hasta; pagi_i++)
            {
                //desde la pagina 1 hasta la ultima pagina (pagi_totalPags)
                if (pagi_i == pagi_actual)
                {
                    //Si el nro de pagina es la actual(pagi_actual). Se escribe el nro pero sin enlace u
                    pagi_navegacion += "<span class='btn btn-default' disabled='disabled'>" + pagi_i + "</span>";
                }
                else
                {
                    // Si es cualquier otro nro. Se escribe el enlace a dicho nro de pagina.
                    pagi_navegacion += "<a class='btn btn-default' href='" + host + "/" + controller + "/" + action +
                        "?id=" + pagi_i + "&Registros=" + pagi_cuantos + "&area=" + area + "'>" + pagi_i + "</a>";
                }
            }
            if (pagi_actual < pagi_totalPags)
            {
                // si no estamos en la ultima pagina. Ponemos el enlace Siguente.
                int pagi_url = pagi_actual + 1; // Sera al nro de pagina que enlazamos
                pagi_navegacion += "<a class='btn btn-default' href='" + host + "/" + controller + "/" +
                    action + "?id=" + pagi_url + "&Registros=" + pagi_cuantos + "&area=" + area + "'>" + pagi_nav_siguiente + "</a>";

                //Si no estamos en la ultima pagina. Ponemos el enlace "Ultima.
                pagi_url = pagi_totalPags; // Sera el nro de pagian que enlazamos.
                pagi_navegacion += "<a class='btn btn-default' href='" + host + "/" + controller + "/" +
                    action + "?id=" + pagi_url + "&Registros=" + pagi_cuantos + "&area=" + area + "'>" + pagi_nav_ultima + "</a>";
            }
            int pagi_inicial = (pagi_actual - 1) * pagi_cuantos;
            var query = table.Skip(pagi_inicial).Take(pagi_cuantos).ToList();

            int pagi_desde = pagi_inicial + 1;
            int pagi_hasta = pagi_inicial + pagi_cuantos;
            if (pagi_hasta > pagi_totalReg)
            {
                pagi_hasta = pagi_totalReg;
            }
            String pagi_info = " del <b>" + pagi_desde + "</b> al <b>" + pagi_hasta + "</b> de <b>" + pagi_totalReg +
                "</b> <b>/" + pagi_cuantos + " Registros por pagina </b>";
            object[] data = { pagi_info, pagi_navegacion, query };
            return data;
        }
    }
}
