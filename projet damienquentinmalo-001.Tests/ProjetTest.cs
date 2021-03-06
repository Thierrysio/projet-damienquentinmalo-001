// <copyright file="ProjetTest.cs">Copyright ©  2020</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using projet_damienquentinmalo_001.Modeles;

namespace projet_damienquentinmalo_001.Modeles.Tests
{
    /// <summary>Cette classe contient des tests unitaires paramétrables pour Projet</summary>
    [PexClass(typeof(Projet))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class ProjetTest
    {
        
        [TestMethod]
        public void ProjetFini()
        {
            Projet p1 = new Projet(1, "projet1");
            bool result = p1.ProjetFini();
            Assert.AreEqual(result, false);

        }
        [TestMethod]
        public void ProjetFini2()
        {
            Projet p1 = new Projet(1, "projet1");
            p1.Etat = "fini";
            bool result = p1.ProjetFini();
            Assert.AreEqual(result, true);

        }
    }
}
