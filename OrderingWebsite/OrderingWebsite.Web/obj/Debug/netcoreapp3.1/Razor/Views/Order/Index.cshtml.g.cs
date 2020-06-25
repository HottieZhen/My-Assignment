#pragma checksum "/Users/k/Documents/ASP.NET_CORE/OrderingWebsite/OrderingWebsite.Web/Views/Order/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07b680bd8e8990f2c8f0e6084638b32a4b327631"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_Index), @"mvc.1.0.view", @"/Views/Order/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07b680bd8e8990f2c8f0e6084638b32a4b327631", @"/Views/Order/Index.cshtml")]
    public class Views_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<script type=\"text/template\" id=\"orderList\">\r\n    <div>\r\n        <div>\r\n");
            WriteLiteral(@"        </div>
        <el-table :data=""tableData""
                  style=""width: 100%"">
            <el-table-column prop=""id""
                             label=""订单号""
                             width=""80"">
            </el-table-column>
            <el-table-column prop=""userName""
                             label=""姓名""
                             width=""100"">
            </el-table-column>
            <el-table-column prop=""address""
                             label=""送货地址"">
            </el-table-column>
            <el-table-column prop=""createTime"" :formatter=""dateFormatter""
                             label=""订餐时间"">
            </el-table-column>
            <el-table-column prop=""price"" width=""100"" :formatter=""format""
                             label=""价格"">
            </el-table-column>
            <el-table-column width=""180""
                             label=""订单状态"">
                <template slot-scope=""scope"">
                    <span v-if=""!scope.row.isEdit"">{{scope.");
            WriteLiteral(@"row.status}}</span>
                    <select v-else class=""el-input__inner"" v-model=""scope.row.status"">
                        <option>已付款</option>
                        <option>备餐中</option>
                        <option>已发货</option>
                        <option>已收货</option>
                        <option>已完成</option>
                        <option>已评价</option>
                    </select>
                </template>
            </el-table-column>

            <el-table-column fixed=""right""
                             label=""操作""
                             width=""180"">
                <template slot-scope=""scope"">
                    <el-button v-if=""!scope.row.isEdit"" ");
            WriteLiteral("@click=\"editStatus(scope.row)\" type=\"primary\" size=\"small\">\r\n                        修改状态\r\n                    </el-button>\r\n                    <span v-else>\r\n                        <el-button v-if=\"scope.row.isEdit\" ");
            WriteLiteral("@click=\"submitStatus(scope.row)\" type=\"success\" size=\"small\">\r\n                            保存\r\n                        </el-button>\r\n                        <el-button v-if=\"scope.row.isEdit\" ");
            WriteLiteral(@"@click=""cancelEditStatus(scope.row)"" type=""danger"" size=""small"">
                            取消
                        </el-button>
                    </span>
                </template>
            </el-table-column>
        </el-table>

        <el-pagination background
                       ");
            WriteLiteral("@size-change=\"pageSizeChange\"\r\n                       ");
            WriteLiteral(@"@current-change=""pageCurrentChange""
                       :page-size=""pagerOpt.pageSize""
                       :current-page=""pagerOpt.page""
                       :total=""pagerOpt.total""
                       :page-sizes=""[2, 10, 20, 50, 100]""
                       layout=""total, sizes, prev, pager, next, jumper"">
        </el-pagination>
    </div>
</script>
<script type=""text/javascript"">var order = {
        template: ""#orderList"",
        data() {
            return {
                tableData: [],

                pagerOpt: {
                    pageSize: 2,
                    page: 1,
                    total: 0,
                },

                backup: """"
            }
        },
        mounted() {
            this.getData();
        },
        methods: {
            getData() {
                var params = `pageNo=${this.pagerOpt.page}&pageSize=${this.pagerOpt.pageSize}`
                _fetch(""/Order/GetOrders?"" + params, ""GET"").then(res => {
                ");
            WriteLiteral(@"    if (res.status = true) {
                        this.tableData = res.data;
                        this.pagerOpt.total = res.total;
                    }
                    else {
                        alert(""系统出错了！"");
                    }
                });
            },

            editStatus(row) {
                row.isEdit = true;
                this.backup = row.status;
            },

            format(row, column) {
                var val = row.price.toFixed(2);

                return `￥${val}元`;
            },

            dateFormatter(row, column) {
                let datetime = row.createTime;
                if (datetime) {
                    datetime = new Date(datetime);
                    let y = datetime.getFullYear() + '-';
                    let mon = datetime.getMonth() + 1 + '-';
                    let d = datetime.getDate();
                    return y + mon + d;
                }
                return ''
            },

           ");
            WriteLiteral(@" cancelEditStatus(item) {
                item.isEdit = false;
                item.status = this.backup;
            },

            submitStatus(item) {
                if (item.status == this.backup) {
                    alert(""请修改状态后再提交！"");
                    return;
                }

                var parms = `id=${item.id}&status=${item.status}`
                _fetch(""/Order/UpdateStatus?"" + parms, ""Post"").then(res => {
                    if (res.status == true) {
                        this.getData();
                    }
                    else {
                        alert(""系统出错了！"");
                    }
                });
            },

            pageSizeChange(val) {
                this.pagerOpt.pageSize = val;
                this.getData();
            },

            pageCurrentChange(val) {
                this.pagerOpt.page = val;
                this.getData();
            }
        }
    }</script>

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
