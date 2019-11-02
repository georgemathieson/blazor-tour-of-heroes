using BlazorState;

namespace TourOfHeroes.Web.Common.Containers.Search.State
{
    /// <inheritdoc/>
    public partial class SearchState
    {
        /// <summary>
        /// Action to reset the query results.
        /// </summary>
        public class ResetAction : IAction
        {
            /// <summary>
            /// Initializes a new instance of the <see cref="ResetAction"/> class.
            /// </summary>
            public ResetAction()
            {
            }
        }
    }
}
