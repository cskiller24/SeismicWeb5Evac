#pragma checksum "C:\Users\Yasuraoka\source\Repos2\SeismicWeb5Evac\SeismicWeb5\Views\Home\Monitor.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fb016161d6259bca7fdc416cb18fcc2766a861ae21c19a10bee719021a193f74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Monitor), @"mvc.1.0.view", @"/Views/Home/Monitor.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Yasuraoka\source\Repos2\SeismicWeb5Evac\SeismicWeb5\Views\_ViewImports.cshtml"
using SeismicWeb5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Yasuraoka\source\Repos2\SeismicWeb5Evac\SeismicWeb5\Views\_ViewImports.cshtml"
using SeismicWeb5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"fb016161d6259bca7fdc416cb18fcc2766a861ae21c19a10bee719021a193f74", @"/Views/Home/Monitor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"35e271372afa81d510bf36531c0e0f6cb90e3cc67486c22b578a5c8584c8947d", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Monitor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SeismicWeb5.Controllers.DataModel>>
    #nullable disable
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Yasuraoka\source\Repos2\SeismicWeb5Evac\SeismicWeb5\Views\Home\Monitor.cshtml"
  
    ViewData["Title"] = "Seismic Monitoring";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb016161d6259bca7fdc416cb18fcc2766a861ae21c19a10bee719021a193f743705", async() => {
                WriteLiteral("\r\n    <script src=\"https://cdn.jsdelivr.net/npm/chart.js@4.4.0/dist/chart.umd.min.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fb016161d6259bca7fdc416cb18fcc2766a861ae21c19a10bee719021a193f744794", async() => {
                WriteLiteral("\r\n<h1>");
#nullable restore
#line 11 "C:\Users\Yasuraoka\source\Repos2\SeismicWeb5Evac\SeismicWeb5\Views\Home\Monitor.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h1>
<br />

<div>
    <canvas id=""seismographChart"" width=""1200"" height=""600""></canvas>
</div>

<script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js""></script>
<script>
    var ctx = document.getElementById('seismographChart').getContext('2d');
    var seismographChart = new Chart(ctx, {
        type: 'line',
        data: {
            labels: [],
            datasets: [
                {
                    label: 'gyroX',
                    borderColor: 'rgb(255, 99, 132)',
                    data: [],
                    fill: false
                },
                {
                    label: 'gyroY',
                    borderColor: 'rgb(75, 192, 192)',
                    data: [],
                    fill: false
                },
                {
                    label: 'gyroZ',
                    borderColor: 'rgb(54, 162, 235)',
                    data: [],
                    fill: false
                }
            ]
       ");
                WriteLiteral(@" },
        options: {
            scales: {
                x: {
                    type: 'linear',
                    position: 'bottom'
                },
                y: {
                    min: -5,
                    max: 5
                }
            }
        }
    });


    async function updateChart() {
        try {
            var response = await fetch('/Home/GetDataFromFirebase', {
                headers: {
                    'Accept': 'application/json'
                }
            });

            if (response.ok) {
                var data = await response.json();
                if (""gyroX"" in data && ""gyroY"" in data && ""gyroZ"" in data) {
                    var timestamp = new Date().getTime().toString();
                    seismographChart.data.labels.push(timestamp);
                    
                    //var formattedTime = timestamp.toLocaleTimeString();
                    //seismographChart.data.labels.push(formattedTime);
             ");
                WriteLiteral(@"       //seismographChart.data.labels.push('');
                    seismographChart.data.datasets[0].data.push(data.gyroX);
                    seismographChart.data.datasets[1].data.push(data.gyroY);
                    seismographChart.data.datasets[2].data.push(data.gyroZ);

                    var maxDataPoints = 30;
                    if (seismographChart.data.labels.length > maxDataPoints) {
                        seismographChart.data.labels = seismographChart.data.labels.slice(-maxDataPoints);
                        seismographChart.data.datasets[0].data = seismographChart.data.datasets[0].data.slice(-maxDataPoints);
                        seismographChart.data.datasets[1].data = seismographChart.data.datasets[1].data.slice(-maxDataPoints);
                        seismographChart.data.datasets[2].data = seismographChart.data.datasets[2].data.slice(-maxDataPoints);
                    }

                    seismographChart.update({
                        preservation: true
      ");
                WriteLiteral(@"              });
                } else {
                    console.error('Error: Unexpected data format from Firebase:', data);
                }
            } else {
                console.error('Error fetching data from Firebase. Status:', response.status);
            }
            setTimeout(updateChart, 100);
        } catch (error) {
            console.error('Error fetching data:', error);
        }
    }
    updateChart();
</script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SeismicWeb5.Controllers.DataModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
