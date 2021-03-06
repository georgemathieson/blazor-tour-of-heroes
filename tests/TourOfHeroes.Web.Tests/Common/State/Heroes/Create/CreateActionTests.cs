using System;
using TourOfHeroes.Web.Common.State.Heroes;
using Xunit;

namespace TourOfHeroes.Web.Tests.Common.State.Heroes.Create
{
    /// <summary>
    /// Unit tests for <see cref="HeroesState.CreateAction"/>.
    /// </summary>
    public class CreateActionTests : HeroesState
    {
        /// <summary>
        /// Happy path.
        /// </summary>
        /// <param name="expectedPayload">The payload to test with.</param>
        [Theory]
        [InlineData("Magneta")]
        [InlineData("Tornado")]
        public void CreateAction_ValidPayload_SetsPayload(string expectedPayload)
        {
            // Given a well formed action.
            var actualPayload = new HeroesState.CreateAction(expectedPayload).Name;

            // It should be instanciated with the given payload.
            Assert.Equal(expectedPayload, actualPayload);
        }

        /// <summary>
        /// If given a null payload, the action should throw an <see cref="ArgumentNullException"/>.
        /// </summary>
        [Fact]
        public void CreateAction_NullPayload_Throws()
        {
            // Given an invalid payload.
            Assert.Throws<ArgumentNullException>(() => new HeroesState.CreateAction(null));
        }
    }
}
