using NUnit.Framework;
using UnityEngine;


    public class LifeShould
    {
        private LifeBar lifeBar;
        
        [SetUp]
        public void Setup()
        {
            lifeBar = new LifeBar(); 
        }

        /*Se puede sumar y restar vida a la barra del jugador. El mínimo es 0 y el máximo es 100. Empieza en 100. Si el jugador
        pierde vida (lo atacan) cuando está en 0, el número no tiene que ir a negativo, y si el jugador gana vida
        (toma una poción) cuando está en 100, el número no tiene que superarlo.*/
        [Test]
        public void BeOneHundredAtTheMost()
        {
            //Given

            //When
            lifeBar.IncrementHealth(20);

            //Then
            Assert.AreEqual(100, lifeBar.Health);
        }

        
        [Test]
        public void BeDecreasedWhenReceivesAttack()
        { 
            //Given

            //When
            lifeBar.DecreaseHealth(50);

            //Then
            Assert.AreEqual(50, lifeBar.Health);

        }
        
        
        [Test]
        public void NotBeNegative()
        { 
            //Given

            //When
            lifeBar.DecreaseHealth(150);

            //Then
            Assert.AreEqual(0, lifeBar.Health);

        }
/*
        /**
         * El jugador puede tomar una poción mágica la cual le da 50 de vida, aún si está en el máximo se le suma.
         * (quedaría en 150). Si el jugador hace heal, no sigue creciendo, no importa si está entre 101 y 150,
         * sólo le sumaría cuando esté de vuelta en algo menor a 100.
         *//*
        public void BeAbleToExceedOneHundredWhenMagicPotionIsUsed()
        {
            //When
            lifeBar.UseMagicPotion();
            
            //Then
            Assert.AreEqual(150, lifeBar.Health);
            
        }*/
/*
        [Test]
        public void NotBeAffectedByHealingWhenHealthOverOneHundred()
        {
            //Given
            lifeBar.UseMagicPotion();
            
            //When
            lifeBar.IncrementHealth(20);
            
            //Then
            Assert.AreEqual(150, lifeBar.Health);
            
        }
*/
        [Test]
        public void NotBeDecreasedWhenPlayerHasShield()
        {
            //When
            lifeBar.AddShield();
            lifeBar.DecreaseHealth(20);
            
            //Then
            Assert.AreEqual(100,lifeBar.Health);


        }
        
        [Test]
        public void BeDecreasedWhenPlayerHasShieldAndReceivesTwoAttacks()
        {
            //Given
            lifeBar.AddShield();
            
            //When
        
            lifeBar.DecreaseHealth(20);
            lifeBar.DecreaseHealth(30);
            
            //Then
            Assert.AreEqual(70,lifeBar.Health);


        }
/*
        [Test]
        public void BeDecreasedTwoTimesWhenPlayerIsPoisoned()
        {
            //Given
            lifeBar.Poison();

            //When
            lifeBar.DecreaseHealth(15);

            //Then
            Assert.AreEqual(70, lifeBar.Health);
        }
*/
    }

  
