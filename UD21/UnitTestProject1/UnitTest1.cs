using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using UD21;

namespace UD21.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void areaCuadrado_Test()
        {
            Geometria cuadradoGeo = new Geometria();
            int resuelto = cuadradoGeo.areacuadrado(5);
            Assert.AreEqual(25, resuelto);
        }

        [TestMethod]
        public void areaCirulo_Test()
        {
            Geometria circuloGeo = new Geometria();
            double resuelto = circuloGeo.areaCirculo(2);
            Assert.AreEqual(12.5664,resuelto);
        }

        [TestMethod]

        public void areaTriangulo_Test()
        {
            Geometria trianguloGeo = new Geometria();
            int resuelto = trianguloGeo.areatriangulo(2,4);
            Assert.AreEqual(4, resuelto);
        }

         [TestMethod]

         public void areaRectangulo_Test()
        {
            Geometria rectanguloGeo = new Geometria();
            int resuelto = rectanguloGeo.arearectangulo(2, 4);
            Assert.AreEqual(8, resuelto);
        }

        [TestMethod]

        public void areaPentagono_Test()
        {
            Geometria pentagonoGeo = new Geometria();
            int resuelto = pentagonoGeo.areapentagono(2,4);
            Assert.AreEqual(4,resuelto);
        }

        [TestMethod]

        public void areaRombo_Test()
        {
            Geometria romboGeo = new Geometria();
            int resuelto = romboGeo.arearombo(2,4);
            Assert.AreEqual(4, resuelto);
        }

        [TestMethod]

        public void areaRomboide_Test()
        {
            Geometria romboideGeo = new Geometria();
            int resuelto = romboideGeo.arearomboide(2,4);
            Assert.AreEqual(8, resuelto);
        }

        public void areaTrapecio_Test()
        {
            Geometria trapecioGeo = new Geometria();
            int resuelto = trapecioGeo.areatrapecio(2,4,6);
            Assert.AreEqual(18, resuelto);
        }

    }
}
