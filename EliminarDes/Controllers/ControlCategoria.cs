using Microsoft.AspNetCore.Mvc;
using Proyeto.Datos;
using Proyeto.Models;


namespace Proyeto.Controllers
{
    public class ControlCategoria : Controller
    {
        CategoriaDatos _ControlCategoria = new CategoriaDatos();

        //METODO DE LISTAR
        public IActionResult ListarCategoria()
        {
            var lista = _ControlCategoria.Listar();
            //MOSTRAR UNA LISTA DE CONTACTOS
            return View(lista);
        }


        //AHORA PARA GUARDAR
        [HttpGet]

        public IActionResult GuardarCategoria()
        {
            //PARA MOSTRAR EL FORMULARIO
            return View();
        }

        [HttpPost]
        public IActionResult GuardarCategoria(CategoriumModel model)
        {
            //PARA OBTENER LOS DATOS DEL FORMULARIO Y ENVIARLOS A LA BASE DE DATOS
            var respuesta = _ControlCategoria.GuardarCategoria(model);
            if (respuesta)
            {
                return RedirectToAction("Listar");
            }
            else
            {
                return View();
            }
        }


        public IActionResult EditarCategoria(int IdCategoria)
        {
            //PARA OBTENER Y MOSTRAR EL CONTACTO A MODIFICAR
            CategoriumModel _Categoria = _ControlCategoria.ObtenerCategoria(IdCategoria);
            return View(_Categoria);
        }

        [HttpPost]

        public IActionResult EditarCategoria(CategoriumModel model)
        {
            //PARA OBTENER LOS DATOS QUE SE EDITARON DEL FOR,ULARIO Y ENVIARLO EN LA BASE DE DATOS
            if (!ModelState.IsValid)
            {
                return View();
            }
            var respuesta = _ControlCategoria.EditarCategoria(model);
            if (respuesta)
            {
                return RedirectToAction("Listar");
            }
            else
            {
                return View();
            }
        }

        public IActionResult EliminarCategoria(int IdCategoria)
        {
            //PARA OBTENER Y MOSTRAR EL CONTACTO A ELIMINAR
            var _contacto = _ControlCategoria.ObtenerCategoria(IdCategoria);
            return View(_contacto);
        }

        [HttpPost]

        public IActionResult EliminarCategoria(CategoriumModel model)
        {
            //PARA OBTENER LOS DATOS QUE SE VAN A LIMINAR DEL FORMULARIO Y ENVIARLOS A A LA BASE D EDATOS

            var respuesta = _ControlCategoria.EliminarCategoria(model.IdCategoria);
            if (respuesta)
            {
                return RedirectToAction("Listar");
            }
            else
            {
                return View();
            }
        }





    }
}