using NUnit.Framework;
using Bonansea.Futbol.Services.WebApi.Controllers;
using Bonansea.Futbol.Infraestructure.Interface;
using Bonansea.Futbol.Application.Interface;
using Bonansea.Futbol.Application.DTO;
using Moq;
using Microsoft.AspNetCore.Mvc;

namespace Bonansea.Futbol.UnitTests
{
    [TestFixture]
    public class JugadorControllerTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void DeleteJugador_LlamadoDeApi_DeleteJugadorDeBd()
        {
            //var repoMoq = new Mock<IJugadorApplication>();
            //repoMoq.Setup()
            //var controller = new JugadorController(repoMoq.Object);

            //INSERT
            //var jugador = new JugadorDto { IdJugador = 4 };
            //controller.Insert(jugador);
            //repoMoq.Verify(r => r.Insert(jugador));

            //DELETE
            //controller.Delete(1);
            //repoMoq.Verify(r => r.Delete(1));

            //Assert.ver();


        }
    }
}


//[TestFixture]
//public class MctParametrosCorePruebasUnitarias
//{
//    private ParametrosCore _core;
//    private Mock<IMctParametrosRepositorio> _repositorio;



//    [SetUp]
//    public void SetUp()
//    {
//        _repositorio = new Mock<IMctParametrosRepositorio>();
//        _core = new ParametrosCore(_repositorio.Object);
//    }



//    [Test]
//    public void Parametros_InsertarIdNoVigente_RetornaErrorNeg1002()
//    {
//        _repositorio.Setup(x => x.ObtenerVigente()).Returns(new BE.MctParametrosBE { Id = 3 });



//        Assert.That(() => _core.Insertar(new BE.MctParametrosBE { Id = 2 }),
//            Throws.Exception.TypeOf<MctException>());
//    }




//    [Test]
//    public void Parametros_InsertarIdNoVigente_SinRetorno()
//    {
//        _repositorio.Setup(x => x.ObtenerVigente()).Returns(new BE.MctParametrosBE { Id = 2 });
//        _repositorio.Setup(x => x.Insertar(It.IsAny<BE.MctParametrosBE>())).Returns(3);



//        var result = _core.Insertar(new BE.MctParametrosBE { Id = 2 });



//        Assert.That(result, Is.EqualTo(3));
//    }
//}