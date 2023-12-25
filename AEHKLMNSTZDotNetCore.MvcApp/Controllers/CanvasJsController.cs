using AEHKLMNSTZDotNetCore.MvcApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace AEHKLMNSTZDotNetCore.MvcApp.Controllers
{
    public class CanvasJsController : Controller
    {
        public IActionResult PieChart()
        {
            return View();
        }
        public IActionResult ParetoChart()
        {
            CanvasJSParetoChartResponseModel model = new CanvasJSParetoChartResponseModel()
            {
                items = new List<CanvasJSParetoChartModel>
                {
                    new CanvasJSParetoChartModel{label="Parking",y=35 },
					new CanvasJSParetoChartModel{label="Rude Sales Rep.",y=69 },
					new CanvasJSParetoChartModel{label="Poor Lighting",y=42 },
					new CanvasJSParetoChartModel{label="Limited Size",y=13 },
					new CanvasJSParetoChartModel{label="Faded Clothes",y=5 }
				}
                

            };

			return View(model);
        }
    }
}
