using System;
using TestSchool;
using NUnit.Framework;
using SchoolProject.Objects;

namespace TestSchool
{
    [TestFixture]
    public class SchuleTests
    {
        [SetUp]
        public void SetUp() { }

        [Test]
        public void Test_AddSchueler_ReturnsCorrectCount()
        {
            Schule schule = new Schule();
            Schueler schueler1 = new Schueler("10A", new DateTime(2005, 06, 15), "männlich");
            Schueler schueler2 = new Schueler("10A", new DateTime(2006, 07, 18), "weiblich");

            schule.AddSchuelerToSchule(schueler1);
            schule.AddSchuelerToSchule(schueler2);

            Assert.AreEqual(2, schule.AnzahlSchueler);
        }
        [Test]
        public void AddSchuelerToSchule_AddTwoSchueler_ReturnsCorrectSchuelerCount()
        {
            Schule schule = new Schule();
            Schueler schueler1 = new Schueler("10A", new DateTime(2005, 06, 15), "männlich");
            Schueler schueler2 = new Schueler("10A", new DateTime(2006, 07, 18), "weiblich");

            schule.AddSchuelerToSchule(schueler1);
            schule.AddSchuelerToSchule(schueler2);

            Assert.AreEqual(2, schule.AnzahlSchueler);
        }

        [Test]
        public void AnzahlSchuelerGeschlecht_CorrectGenderCount_ReturnsCorrectResult()
        {
            Schule schule = new Schule();
            Schueler schueler1 = new Schueler("10A", new DateTime(2005, 06, 15), "männlich");
            Schueler schueler2 = new Schueler("10A", new DateTime(2006, 07, 18), "weiblich");

            schule.AddSchuelerToSchule(schueler1);
            schule.AddSchuelerToSchule(schueler2);

            string result = schule.AnzahlSchülerGeschlecht;

            Assert.AreEqual("männliche: 1 / weibliche: 1", result);
        }

        [Test]
        public void DurchschnittsalterSchueler_AvgAge_ReturnsCorrectResult()
        {
            Schule schule = new Schule();
            Schueler schueler1 = new Schueler("10A", new DateTime(2005, 06, 15), "männlich");
            Schueler schueler2 = new Schueler("10A", new DateTime(2006, 07, 18), "weiblich");

            schule.AddSchuelerToSchule(schueler1);
            schule.AddSchuelerToSchule(schueler2);

            float avgAge = schule.DurchschnittsalterSchueler();

            Assert.AreEqual(19.5, avgAge);
        }

        [Test]
        public void BerechneFrauenanteilInProzent_CalculateFemalePercentage_ReturnsCorrectPercentage()
        {
            Schule schule = new Schule();
            Schueler schueler1 = new Schueler("10A", new DateTime(2005, 06, 15), "männlich");
            Schueler schueler2 = new Schueler("10A", new DateTime(2006, 07, 18), "weiblich");
            Schueler schueler3 = new Schueler("10A", new DateTime(2007, 08, 20), "weiblich");

            schule.AddSchuelerToSchule(schueler1);
            schule.AddSchuelerToSchule(schueler2);
            schule.AddSchuelerToSchule(schueler3);

            double femalePercentage = schule.BerechneFrauenanteilInProzent(schule.SchuelerList, "10A");

            Assert.AreEqual(66.67, femalePercentage, 0.01);
        }

        [Test]
        public void KannKlasseUnterrichten_EnoughSpace_ReturnsTrue()
        {
            Schule schule = new Schule();
            Klassenraum klassenraum = new Klassenraum(50, 30, false);
            Schueler schueler1 = new Schueler("10A", new DateTime(2005, 06, 15), "männlich");
            Schueler schueler2 = new Schueler("10A", new DateTime(2006, 07, 18), "weiblich");

            schule.AddKlassenraumToSchule(klassenraum);
            schule.AddSchuelerToSchule(schueler1);
            schule.AddSchuelerToSchule(schueler2);

            bool result = schule.KannKlasseUnterrichten("10A", "50");

            Assert.IsTrue(result);
        }

        [Test]
        public void KannKlasseUnterrichten_NotEnoughSpace_ReturnsFalse()
        {
            Schule schule = new Schule();
            Klassenraum klassenraum = new Klassenraum(50, 1, false);
            Schueler schueler1 = new Schueler("10A", new DateTime(2005, 06, 15), "männlich");
            Schueler schueler2 = new Schueler("10A", new DateTime(2006, 07, 18), "weiblich");

            schule.AddKlassenraumToSchule(klassenraum);
            schule.AddSchuelerToSchule(schueler1);
            schule.AddSchuelerToSchule(schueler2);

            bool result = schule.KannKlasseUnterrichten("10A", "50");

            Assert.IsFalse(result);
        }
    }
}