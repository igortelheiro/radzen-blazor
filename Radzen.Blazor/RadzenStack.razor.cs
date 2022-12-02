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
        /// Gets or sets the orientation.
        /// </summary>
        /// <value>The orientation.</value>
        [Parameter]
        public JustifyContent JustifyContent { get; set; } = JustifyContent.Normal;

        /// <summary>
        /// Gets or sets the orientation.
        /// </summary>
        /// <value>The orientation.</value>
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
            return $"{Style};{(!string.IsNullOrEmpty(Spacing) ? "gap:" + Spacing + (Spacing.All(c => Char.IsDigit(c)) ? "px;" : "") : "")}";
        }

        /// <inheritdoc />
        protected override string GetComponentCssClass()
        {
            var horizontal = Orientation == Orientation.Horizontal;

            return $"rz-display-flex rz-flex-{(horizontal ? "row" : "column")}{(Reverse ? "-reverse" : "")} rz-align-items-{ToDashCase(Enum.GetName(typeof(AlignItems), AlignItems))} rz-justify-content-{ToDashCase(Enum.GetName(typeof(JustifyContent), JustifyContent))}";
        }

        static string ToDashCase(string text)
        {
            if (text == null)
            {
                throw new ArgumentNullException(nameof(text));
            }
            if (text.Length < 2)
            {
                return text;
            }
            var sb = new StringBuilder();
            sb.Append(char.ToLowerInvariant(text[0]));
            for (int i = 1; i < text.Length; ++i)
            {
                char c = text[i];
                if (char.IsUpper(c))
                {
                    sb.Append('-');
                    sb.Append(char.ToLowerInvariant(c));
                }
                else
                {
                    sb.Append(c);
                }
            }
            return sb.ToString();
        }
    }
}
