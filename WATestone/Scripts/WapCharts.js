﻿

function DrawPie(data,id) {

    var option = ECharts.ChartOptionTemplates.Pie(data);
    var container = document.getElementById(id);
    opt = ECharts.ChartConfig(container, option);
    ECharts.Charts.RenderChart(opt);

}
 

function DrawBar(data, id) {

    var option = ECharts.ChartOptionTemplates.Bars(data,"张斌");
    var container = document.getElementById(id);
    opt = ECharts.ChartConfig(container, option);
    ECharts.Charts.RenderChart(opt);

}

function DrawLine(data, id)
{
    var option = ECharts.ChartOptionTemplates.Lines(data,"张琪");//创建option对象
    var container = document.getElementById(id);
    opt = ECharts.ChartConfig(container, option);

    ECharts.Charts.RenderChart(opt);
}