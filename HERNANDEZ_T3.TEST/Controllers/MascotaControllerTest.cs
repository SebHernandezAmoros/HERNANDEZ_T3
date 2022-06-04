using HERNANDEZ_T3.WEB.Controllers;
using HERNANDEZ_T3.WEB.Models;
using HERNANDEZ_T3.WEB.Repositories;
using Microsoft.AspNetCore.Mvc;
using Moq;
using NUnit.Framework;

namespace HERNANDEZ_T3.TEST.Controllers
{
    class MascotaControllerTest
    {
        [Test]
        public void CreateMascota01()
        {
            var mockMascotaRepositorio = new Mock<IMascotaRepositorio>();

            var controller = new MascotaController(mockMascotaRepositorio.Object);
            var view = controller.CreateNew();

            Assert.IsNotNull(view);

        }
        [Test]
        public void CreateMascota02()
        {
            var mockMascotaRepositorio = new Mock<IMascotaRepositorio>();

            var controller = new MascotaController(mockMascotaRepositorio.Object);
            var result = controller.CreateNew(new Mascota { Nombre = "Guts", Especie="Perro"});

            Assert.IsNotNull(result);
            Assert.IsInstanceOf<ViewResult>(result);
        }
    }
}
