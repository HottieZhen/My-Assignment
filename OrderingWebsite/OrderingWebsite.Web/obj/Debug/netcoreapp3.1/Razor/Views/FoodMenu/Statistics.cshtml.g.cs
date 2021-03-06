#pragma checksum "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/FoodMenu/Statistics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7b275763c4ff6588f07cc92ad6ee005d5160823"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FoodMenu_Statistics), @"mvc.1.0.view", @"/Views/FoodMenu/Statistics.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7b275763c4ff6588f07cc92ad6ee005d5160823", @"/Views/FoodMenu/Statistics.cshtml")]
    public class Views_FoodMenu_Statistics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script type=""text/template"" id=""statisticList"">
    <div>
        <div style=""text-align: right"">
            <el-date-picker v-model=""start""
                            type=""date""
                            placeholder=""选择日期"">
            </el-date-picker>
            <el-date-picker v-model=""end""
                            type=""date""
                            placeholder=""选择日期"">
            </el-date-picker>

            <el-button type=""primary"" ");
            WriteLiteral(@"@click=""getData()"">查询</el-button>
        </div>

        <el-table :data=""tableData"" v-loading=""loading""
                  style=""width: 100%"">
            <el-table-column prop=""foodName""
                             label=""菜名"">
            </el-table-column>
            <el-table-column prop=""count""
                             label=""销量"">
            </el-table-column>
            <el-table-column prop=""price"" width=""100"" :formatter=""format""
                             label=""金额"">
            </el-table-column>
        </el-table>
    </div>
</script>

<script type=""text/javascript"">
    var statistics = {
        template: '#statisticList',
        data() {
            return {
                tableData: [],
                start: null,
                end: null,
                loading: true
            }
        },
        mounted() {
            this.getData();
        },
        methods: {
            getData() {
                var startDate = moment(this.start).fo");
            WriteLiteral(@"rmat(""YYYY-MM-DD"");
                var startEnd = moment(this.end).format(""YYYY-MM-DD"");
                var params = `start=${startDate}&end=${startEnd}`;
                this.loading = true;
                _fetch(""/FoodMenu/GetStatistics?"" + params, ""GET"").then(res => {
                    if (res.status = ""Success"") {
                        this.tableData = res.data;
                    }
                    else {
                        alert(""系统出错了！"");
                    }

                    this.loading = false;
                });
            },

            format(row, column) {
                var val = row.price.toFixed(2);

                return `￥${val}元`;
            }
        }
    };
</script>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
