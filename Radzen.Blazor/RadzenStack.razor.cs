using Microsoft.AspNetCore.Components;
using System;
using System.Linq;
using System.Text;

namespace Radzen.Blazor
{
    /// <summary>
    /// RadzenCard component.
    /// </summary>
    public partial class RadzenStack : RadzenComponentWithChildren
    {
        /// <summary>
        /// Gets or sets the content justify.
        /// </summary>
        /// <value>The content justify.</value>
        [Parameter]
        public JustifyContent JustifyContent { get; set; } = JustifyContent.Normal;

        /// <summary>
        /// Gets or sets the items alignment.
        /// </summary>
        /// <value>The items alignment.</value>
        [Parameter]
        public AlignItems AlignItems { get; set; } = AlignItems.Normal;

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
        /// Gets or sets the reverse
        /// </summary>
        /// <value>The reverse.</value>
        [Parameter]
        public bool Reverse { get; set; }

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
            return $"{Style}{(!string.IsNullOrEmpty(Style) && !Style.EndsWith(";") ? ";" : "")}{(!string.IsNullOrEmpty(Spacing) ? "gap:" + Spacing + (Spacing.All(c => Char.IsDigit(c)) ? "px;" : "") : "")}";
        }

        /// <inheritdoc />
        protected override string GetComponentCssClass()
        {
            var horizontal = Orientation == Orientation.Horizontal;

            return $"rz-display-flex rz-flex-{(horizontal ? "row" : "column")}{(Reverse ? "-reverse" : "")} rz-align-items-{GetFlexCSSClass<AlignItems>(AlignItems)} rz-justify-content-{GetFlexCSSClass<JustifyContent>(JustifyContent)}";
        }

        string GetFlexCSSClass<T>(Enum v)
        {
            var value = ToDashCase(Enum.GetName(typeof(T), v));
            return value == "start" || value == "end" ? $"flex-{value}" : value;
        }

        static string ToDashCase(string value)
        {
            var sb = new StringBuilder();

            foreach (var ch in value)
            {
                if ((char.IsUpper(ch) && sb.Length > 0) || char.IsSeparator(ch))
                {
                    sb.Append('-');
                }

                if (char.IsLetterOrDigit(ch))
                {
                    sb.Append(char.ToLowerInvariant(ch));
                }
            }

            return sb.ToString();
        }
    }
}
