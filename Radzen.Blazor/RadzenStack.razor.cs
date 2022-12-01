using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radzen.Blazor
{
    /// <summary>
    /// RadzenCard component.
    /// </summary>
    public partial class RadzenStack : RadzenComponentWithChildren
    {
        /// <summary>
        /// Gets or sets the orientation.
        /// </summary>
        /// <value>The orientation.</value>
        [Parameter]
        public Orientation Orientation { get; set; } = Orientation.Vertical;

        /// <summary>
        /// Gets or sets the spacing
        /// </summary>
        /// <value>The spacing.</value>
        [Parameter]
        public string Spacing { get; set; }

        /// <summary>
        /// Gets the final CSS style rendered by the component. Combines it with a <c>style</c> custom attribute.
        /// </summary>
        protected string GetStyle()
        {
            if (Attributes != null && Attributes.TryGetValue("style", out var style) && !string.IsNullOrEmpty(Convert.ToString(@style)))
            {
                return $"{GetComponentStyle()} {@style}";
            }

            return GetComponentStyle();
        }

        /// <summary>
        /// Gets the component CSS style.
        /// </summary>
        protected string GetComponentStyle()
        {
            var horizontal = Orientation == Orientation.Horizontal;

            return $"display:grid;grid-auto-flow:{(horizontal ? "column" : "row")};grid-auto-{(horizontal ? "columns" : "rows")}:max-content;grid-template-{(horizontal ? "columns" : "rows")}: none;{(!string.IsNullOrEmpty(Spacing) ? "grid-gap:" + Spacing + (Spacing.All(c => Char.IsDigit(c)) ? "px;" : "") : "")}";
        }
    }
}
