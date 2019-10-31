using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorState;
using MediatR;
using TourOfHeroes.Web.Common;
using TourOfHeroes.Web.Pages.Heroes.Models;

namespace TourOfHeroes.Web.Pages.Heroes.State
{
    /// <inheritdoc/>
    public partial class HeroesState
    {
        /// <summary>
        /// Deals with the side effects of dispatching a <see cref="HeroesState.CreateAction"/> and updates the state accordingly.
        /// </summary>
        internal class HandleCreate : BaseHandler<HeroesState.CreateAction>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="HandleCreate"/> class.
            /// </summary>
            /// <param name="store">The single source of truth to create with.</param>
            public HandleCreate(IStore store) 
                : base(store) 
            {
            }

            /// <inheritdoc/>
            public override Task<Unit> Handle(HeroesState.CreateAction aAction, CancellationToken aCancellationToken)
            {
                // TODO: Make service call.
                var id = 1;

                if (HeroesState.Heroes.Any())
                {
                    id = HeroesState.Heroes.Max(hero => hero.Id + 1);
                }

                var heroToAppend = new Hero
                {
                    Id = id,
                    Name = aAction.Name
                };

                HeroesState.Heroes.Add(heroToAppend);

                return Unit.Task;
            }
        }
    }
}