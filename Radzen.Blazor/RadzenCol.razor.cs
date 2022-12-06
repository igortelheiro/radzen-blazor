using Microsoft.AspNetCore.Components;
using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Radzen.Blazor
{
    /// <summary>
    /// RadzenCard component.
    /// </summary>
    public partial class RadzenCol : RadzenRowCol
    {
        /// <summary>
        /// Gets or sets the XS size.
        /// </summary>
        /// <value>The XS size.</value>
        [Parameter]
        [Range(0, 12)]
        public int SizeXS { get; set; }

        /// <summary>
        /// Gets or sets the SM size.
        /// </summary>
        /// <value>The SM size.</value>
        [Parameter]
        [Range(0, 12)]
        public int SizeSM { get; set; }

        /// <summary>
        /// Gets or sets the MD size.
        /// </summary>
        /// <value>The MD size.</value>
        [Parameter]
        [Range(0, 12)]
        public int SizeMD { get; set; }

        /// <summary>
        /// Gets or sets the LG size.
        /// </summary>
        /// <value>The LG size.</value>
        [Parameter]
        [Range(0, 12)]
        public int SizeLG { get; set; }

        /// <summary>
        /// Gets or sets the XL size.
        /// </summary>
        /// <value>The XL size.</value>
        [Parameter]
        [Range(0, 12)]
        public int SizeXL { get; set; }

        /// <summary>
        /// Gets or sets the XS offset.
        /// </summary>
        /// <value>The XS offset.</value>
        [Parameter]
        [Range(0, 12)]
        public int OffsetXS { get; set; }

        /// <summary>
        /// Gets or sets the SM offset.
        /// </summary>
        /// <value>The SM offset.</value>
        [Parameter]
        [Range(0, 12)]
        public int OffsetSM { get; set; }

        /// <summary>
        /// Gets or sets the MD offset.
        /// </summary>
        /// <value>The MD offset.</value>
        [Parameter]
        [Range(0, 12)]
        public int OffsetMD { get; set; }

        /// <summary>
        /// Gets or sets the LG offset.
        /// </summary>
        /// <value>The LG offset.</value>
        [Parameter]
        [Range(0, 12)]
        public int OffsetLG { get; set; }

        /// <summary>
        /// Gets or sets the XL offset.
        /// </summary>
        /// <value>The XL offset.</value>
        [Parameter]
        [Range(0, 12)]
        public int OffsetXL { get; set; }

        /// <summary>
        /// Gets or sets the XS order.
        /// </summary>
        /// <value>The XS order.</value>
        [Parameter]
        [Range(0, 12)]
        public int OrderXS { get; set; }

        /// <summary>
        /// Gets or sets the SM order.
        /// </summary>
        /// <value>The SM order.</value>
        [Parameter]
        [Range(0, 12)]
        public int OrderSM { get; set; }

        /// <summary>
        /// Gets or sets the MD order.
        /// </summary>
        /// <value>The MD order.</value>
        [Parameter]
        [Range(0, 12)]
        public int OrderMD { get; set; }

        /// <summary>
        /// Gets or sets the LG order.
        /// </summary>
        /// <value>The LG order.</value>
        [Parameter]
        [Range(0, 12)]
        public int OrderLG { get; set; }

        /// <summary>
        /// Gets or sets the XL order.
        /// </summary>
        /// <value>The XL order.</value>
        [Parameter]
        [Range(0, 12)]
        public int OrderXL { get; set; }

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
            return $"{Style}{(!string.IsNullOrEmpty(Style) && !Style.EndsWith(";") ? ";" : "")}";
        }

        /// <inheritdoc />
        protected override string GetComponentCssClass()
        {
            return $"rz-col";
        }
    }
}
