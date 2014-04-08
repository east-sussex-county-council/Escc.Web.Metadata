using System;
using System.Globalization;
using System.IO;
using System.Web;
using System.Web.UI;

namespace EsccWebTeam.Egms
{
	/// <summary>
	/// Container control for metadata values specified using other controls in a template
	/// </summary>
	public class MetadataContainer : Control, INamingContainer
	{
		/// <summary>
		/// Gets the encoded XHTML generated by the control
		/// </summary>
		/// <returns>XHTML encoded as a string</returns>
		/// <remarks>This approach not currently used because it requires a higher trust level to work.</remarks>
		public override string ToString()
		{
			using (StringWriter sw = new StringWriter(CultureInfo.CurrentCulture))
			{
				using (HtmlTextWriter xhtmlWriter = new HtmlTextWriter(sw))
				{
					this.RenderControl(xhtmlWriter);
					return HttpUtility.HtmlAttributeEncode(sw.ToString().Trim());
				}
			}
		}
	}
}
