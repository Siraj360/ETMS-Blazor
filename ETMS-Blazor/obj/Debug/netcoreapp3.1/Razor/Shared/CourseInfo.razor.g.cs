#pragma checksum "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e582c30f2551ee89cc800fe0190edc6ddaaf143d"
// <auto-generated/>
#pragma warning disable 1591
namespace ETMS_Blazor.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using ETMS_Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using ETMS_Blazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using ETMS.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\_Imports.razor"
using ETMS.Data.Service;

#line default
#line hidden
#nullable disable
    public partial class CourseInfo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "tr");
            __builder.AddMarkupContent(1, "\r\n    ");
            __builder.OpenElement(2, "td");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-header cursor-pointer");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                                                              ShowHideList

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(10, "\r\n\r\n                ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row");
            __builder.AddMarkupContent(13, "\r\n                    ");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "col-md-10");
            __builder.AddMarkupContent(16, "\r\n                        ");
            __builder.OpenElement(17, "span");
            __builder.AddAttribute(18, "class", "btn" + " btn-secondary" + " btn-sm" + " " + (
#nullable restore
#line 16 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                                                               ShowHideArrowCssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(19, "\r\n                            <i class=\"fas fa-arrow-up\"></i>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                        ");
            __builder.OpenElement(21, "span");
            __builder.AddAttribute(22, "class", "btn" + " btn-secondary" + " btn-sm" + " " + (
#nullable restore
#line 19 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                                                               ShowHideListCssClass

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "\r\n                            <i class=\"fas fa-arrow-down\"></i>\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        &nbsp;\r\n                        ");
            __builder.OpenElement(25, "span");
            __builder.AddAttribute(26, "class", "badge badge-pill badge-primary");
            __builder.AddContent(27, " ");
            __builder.AddContent(28, 
#nullable restore
#line 23 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                                                                       cx

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                        &nbsp;  ");
            __builder.OpenElement(30, "a5");
            __builder.AddAttribute(31, "style", "font-weight:bold");
            __builder.AddContent(32, 
#nullable restore
#line 24 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                                                              course.Code

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, " &nbsp;\r\n                        : &nbsp;  ");
            __builder.OpenElement(34, "a5");
            __builder.AddAttribute(35, "style", "font-weight:bold");
            __builder.AddContent(36, 
#nullable restore
#line 25 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                                                                course.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, " &nbsp;\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                    ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "col-md-2 float-right");
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.OpenElement(42, "strong");
            __builder.AddContent(43, 
#nullable restore
#line 28 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                                 course.TotalCoursesCompleted

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(44, " / ");
            __builder.AddContent(45, 
#nullable restore
#line 28 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                                                                 course.TotalCoursesAssined

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "&nbsp;\r\n                        ");
            __builder.OpenElement(47, "span");
            __builder.AddAttribute(48, "class", "badge badge-dark");
            __builder.AddContent(49, 
#nullable restore
#line 29 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                                                        course.PercentCourcesCompleted

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "&nbsp;\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", 
#nullable restore
#line 34 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                         ShowHideListCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(56, "\r\n                ");
            __builder.OpenElement(57, "table");
            __builder.AddAttribute(58, "class", "table table-sm  table-bordered");
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.AddMarkupContent(60, @"<thead>
                        <tr>
                            <th scope=""col"" class=""text-center"">#</th>
                            <th scope=""col"">Employee</th>
                            <th scope=""col"" class=""text-center"">Hire Date</th>
                            <th class=""text-center"" scope=""col"">Completed?</th>
                            <th scope=""col"" class=""text-center""> Make ...</th>
                        </tr>
                    </thead>
                    ");
            __builder.OpenElement(61, "tbody");
            __builder.AddMarkupContent(62, "\r\n");
#nullable restore
#line 46 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                         if (course.EmployeeCourses != null && course.EmployeeCourses.Count > 0)
                        {
                            ex = 1;
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                             foreach (var employeeCourses in course.EmployeeCourses)
                            {
                                string rowClass = $"{(employeeCourses.isComplete ? "table-success" : "")}";

#line default
#line hidden
#nullable disable
            __builder.AddContent(63, "                                ");
            __builder.OpenElement(64, "tr");
            __builder.AddAttribute(65, "class", 
#nullable restore
#line 52 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                                              rowClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(66, "\r\n                                    ");
            __builder.OpenElement(67, "th");
            __builder.AddAttribute(68, "scope", "row");
            __builder.AddAttribute(69, "class", "text-center");
            __builder.AddMarkupContent(70, "\r\n                                        ");
            __builder.OpenElement(71, "span");
            __builder.AddAttribute(72, "class", "badge badge-pill badge-dark");
            __builder.AddContent(73, 
#nullable restore
#line 54 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                                                                                   ex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n                                    ");
            __builder.OpenElement(76, "td");
            __builder.AddContent(77, 
#nullable restore
#line 56 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                                         employeeCourses.Employee.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n                                    ");
            __builder.OpenElement(79, "td");
            __builder.AddAttribute(80, "class", "text-center");
            __builder.AddContent(81, 
#nullable restore
#line 57 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                                                             employeeCourses.Employee.HireDate.Date.ToString("dd MMM yyyy")

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n                                    ");
            __builder.OpenElement(83, "td");
            __builder.AddAttribute(84, "class", "text-center");
            __builder.AddMarkupContent(85, "\r\n");
#nullable restore
#line 59 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                                         if (employeeCourses.isComplete)
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(86, "                                            <span class=\"oi oi-circle-check\"></span>\r\n");
#nullable restore
#line 62 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(87, "                                            <span class=\"oi oi-circle-x\"></span>\r\n");
#nullable restore
#line 66 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(88, "                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(89, "\r\n                                    ");
            __builder.OpenElement(90, "td");
            __builder.AddAttribute(91, "class", "text-center");
            __builder.AddMarkupContent(92, "\r\n");
#nullable restore
#line 69 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                                         if (employeeCourses.isComplete)
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(93, "                                            ");
            __builder.OpenElement(94, "button");
            __builder.AddAttribute(95, "type", "button");
            __builder.AddAttribute(96, "class", "btn btn-danger btn-sm");
            __builder.AddAttribute(97, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 71 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                                                                                                          ()=>ChangeCompleteStatus(employeeCourses.EmployeeCourseID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(98, "Uncomplete");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n");
#nullable restore
#line 72 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(100, "                                            ");
            __builder.OpenElement(101, "button");
            __builder.AddAttribute(102, "type", "button");
            __builder.AddAttribute(103, "class", "btn btn-success btn-sm");
            __builder.AddAttribute(104, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 75 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                                                                                                           ()=>ChangeCompleteStatus(employeeCourses.EmployeeCourseID)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(105, "Complete");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n");
#nullable restore
#line 76 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(107, "                                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(108, "\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n");
#nullable restore
#line 79 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                                ex++;
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                             
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(110, "                            ");
            __builder.AddMarkupContent(111, "<tr class=\"table-warning\">\r\n                                <td colspan=\"5\" scope=\"row\">&nbsp;&nbsp;<span class=\"oi oi-warning\"></span>&nbsp;Course not assigned to employee.</td>\r\n                            </tr>\r\n");
#nullable restore
#line 87 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
                        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(112, "                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n\r\n          ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
 
    int ex = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 100 "C:\Users\Siraj\source\repos\ETMS-Blazor\ETMS-Blazor\Shared\CourseInfo.razor"
       
    [Parameter]
    public string courseId { get; set; }
    [Parameter]
    public int cx { get; set; }



    //public int _cx;
    //[Parameter]
    //public int cx {
    //    get
    //    {
    //        return _cx;
    //    }
    //    set {
    //        _cx = value;
    //        //if (value == 2)
    //        //{
    //        //    isShowList = true;
    //        //}
    //        //else
    //        //{
    //        //    isShowList = false;
    //        //}
    //    }
    //}




    Course course;

    protected override async Task OnInitializedAsync()
    {
        course = await CourseService.GetCourseInfo(courseId);
    }


    private async Task ChangeCompleteStatus(int id)
    {
        await EmployeeCourseService.ChangeCompleteStatus(id);
    }

    private bool isShowList = false;
    private string ShowHideListCssClass => isShowList ? "is_show" : "is_hide";
    private string ShowHideArrowCssClass => isShowList ? "is_hide" : "is_show";

    private void ShowHideList()
    {
        isShowList = !isShowList;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmployeeCourseService EmployeeCourseService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICourseService CourseService { get; set; }
    }
}
#pragma warning restore 1591
