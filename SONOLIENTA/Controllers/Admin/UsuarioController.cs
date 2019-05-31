﻿using BLL_SONOLIENTA;
using BLL_SONOLIENTA.Utilidades;
using DAO_SONOLIENTA;
using DAO_SONOLIENTA.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SONOLIENTA.Controllers.Admin
{
    public class UsuarioController : Controller
    {
        public ActionResult Index()
        {
            BLL_Usuario BLL_Usuario = new BLL_Usuario();
            return View(BLL_Usuario.ListUsuarios(EnumFiltroEstado.Todos));
        }

        [HttpGet]
        public ActionResult UsuarioAdd()
        {
            ViewBag.Estado = new SelectList(FuncionesEnum.ListaEnum<EnumEstados>(), "Value", "Text");
            return View();
        }

        [HttpPost]
        public ActionResult UsuarioAdd(USUARIO USUARIO)
        {
            ViewBag.Estado = new SelectList(FuncionesEnum.ListaEnum<EnumEstados>(), "Value", "Text", USUARIO.Estado);

            if (ModelState.IsValid)
            {
                BLL_Usuario BLL_Usuario = new BLL_Usuario();
                if (BLL_Usuario.GuardarUsuario(USUARIO))
                {// pregunta si la funcion de creacion se ejecuto con exito
                    return RedirectToAction("Index");
                }
                else
                {// no creado

                    return View(USUARIO);
                }
            }
            else
            {
                return View(USUARIO);
            }
        }


        //Update
        [HttpGet]
        public ActionResult UsuarioUpdt(int id)
        {
            BLL_Usuario BLL_Usuario = new BLL_Usuario();
            USUARIO Usuario = BLL_Usuario.GetUsuarioByUsuarioId(id);
            ViewBag.Estado = new SelectList(FuncionesEnum.ListaEnum<EnumEstados>(), "Value", "Text", Usuario.Estado);

            return View(Usuario);
        }

        //Update
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult UsuarioUpdt(USUARIO USUARIO)
        {
            ViewBag.Estado = new SelectList(FuncionesEnum.ListaEnum<EnumEstados>(), "Value", "Text", USUARIO.Estado);

            if (USUARIO != null)
            {
                if (ModelState.IsValid)
                {
                    BLL_Usuario BLL_Usuario = new BLL_Usuario();
                    if (BLL_Usuario.ModificarUsuario(USUARIO))
                    {
                        return RedirectToAction("Index");
                    }
                    else
                    {
                        return View(USUARIO);
                    }
                }
                else
                {
                    return View(USUARIO);
                }
            }
            else
            {
                return View(USUARIO);
            }
        }



    }
}


