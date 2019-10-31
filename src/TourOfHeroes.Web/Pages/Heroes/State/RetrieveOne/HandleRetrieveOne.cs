using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using BlazorState;
using MediatR;
using TourOfHeroes.Web.Common;

namespace TourOfHeroes.Web.Pages.Heroes.State
{
    /// <inheritdoc/>
    public partial class HeroesState
    {
        /// <summary>
        /// Deals with the side effects of dispatching a <see cref="HeroesState.RetrieveOneAction"/> and updates the state accordingly.
        /// </summary>
        internal class HandleRetrieveOne : BaseHandler<HeroesState.RetrieveOneAction>
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="HandleRetrieveOne"/> class.
            /// </summary>
            /// <param name="store">The single source of truth to create with.</param>
            public HandleRetrieveOne(IStore store)
                : base(store)
            {
            }

            /// <inheritdoc/>
            public override Task<Unit> Handle(HeroesState.RetrieveOneAction aAction, CancellationToken aCancellationToken)
            {
                // TODO: Make service call.
                HeroesState.Hero = HeroesState.Heroes.FirstOrDefault(hero => hero.Id == aAction.Id);

                return Unit.Task;
            }
        }
    }
}