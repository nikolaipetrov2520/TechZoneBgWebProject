namespace TechZoneBgWebProject.Services.PDF
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using TechZoneBgWebProject.Web.ViewModels.Devices;

    public class TemplateGenerator : ITemplateGenerator
    {
        public string Generate(DeviceDetailsViewModel device)
        {
            var sb = new StringBuilder();

            sb.Append(@$"
                        <html>
                            <head>
                               <link rel=""stylesheet"" href=""{Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\lib\\bootstrap\\dist\\css", "bootstrap.css" )}"" asp-append-version=""true"" />
                            </head>
                            <body>
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-xl-9 main"">
                <main role=""main"" class=""pb-3"">
                <div class=""tt-tab-wrapper"">
                    <nav class=""tt-topic-list cart-list"" style=""word-break: break-word; margin: 40px 0px;"">
                        <h2 style=""text-align: center;
                            text-align: center;
                            padding: 20px;
                            margin-bottom: 20px;
                            background-color: #efeeee;"">
                            Досие на устройството
                        </h2>
                        <div>
                            <div>
                                <h1>{device.DeviceModel} {device.Memory} {device.Color}</h1>
                            </div>
                            <div>
                                <h3>Закупен от: {device.Seller}</h3>
                            </div>
                            <div class=""form-group-conteiner"">
                                <div>
                                    <div style=""font-size: 20px; display:inline-block"" >IMEI</div>
                                    <div class=""checkList-input-text"" style=""font-size: 20px; display:inline-block; border:none"">{device.Imei}</div>
                                    <div style=""border: 1px solid #dfdfdf; width: 90%; margin: 20px auto; padding: 20px;"">
                                    <table align=""center"" style=""margin: 0px;"">
                                          <thead>
                                            <tr class=""thead-cart"">
                                                <th class=""order-name-check"">Проверка за:</th>
                                                <th class=""order-condition-check"">Състояние</th>
                                                <th class=""order-description-check"">Бележка</th>
                                            </tr>
                                        </thead>
                                        <tbody>
                                    ");
            foreach (var check in device.Checks)
            {
                sb.Append(@$"
                     <tr class=""tt-itemOrder-check order-name"" style""border-bottom: 1px solid #b5bebfad;"">
                         <td class=""order-name-check"">
                             <div class=""checkList-label"">{check.Name}</div>
                          </td>
                          <td class=""order-condition-check"">
                              <div>");
                if (check.Condition == true)
                {
                     sb.Append(@$"
                          <div>
                              <img src=""{Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", "checkedIcon.png")}"" width=""14"" />
                          </div>");
                }
                else if (check.Condition == false)
                {
                    sb.Append(@$"
                        <div>
                            <img src=""{Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images", "NotCheckedIcon.png")}"" width=""14"" />
                        </div>");
                }
                else
                {
                    sb.Append(@"
                         <div>не е проверен</div>");
                }

                sb.Append(@$"
                    </ td>
                    <td class=""cart-text cart-quantity order-description-check"">
                         <div class=""checkList-description"">{check.Description}</div>
                    </td>
                </tr>");
            }

            sb.Append(@$"
                            </tbody>
                                    </table>
                                    </div>
                                    <div class=""select-list"" style=""border-bottom: 1px solid #ebe9e9;"">
                                        <div class=""create-device"">
                                            <div class=""details-label"">Описание на състоянието</div>
                                            <div>{device.Description}</div>
                                        </div>
                                    </div>
                                    <div class=""select-list"" style=""border-bottom: 1px solid #ebe9e9;"">
                                        <div class=""create-device"" >
                                            <div class=""details-label"">Категория на устройството</div>
                                            <div>{device.Condition}</div>
                                        </div>
                                        <div class=""create-device"">
                                            <div class=""details-label"">Ремонти</div>
                                            <div>{device.Repairs}</div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </nav>
                    </div>
                </main>
            </div>
        </div>
    </div>     
                            </body>
                        </html>");

            return sb.ToString();
        }
    }
}
