    window.onload = function () {
        // 初始化图表
        var chart = klinecharts.init('chart')
        // 创建一个主图技术指标
        chart.createTechnicalIndicator('MA', false, { id: 'candle_pane' })
        // 创建一个副图技术指标VOL
        // chart.createTechnicalIndicator('VOL')
        // // 创建一个副图技术指标MACD
        // chart.createTechnicalIndicator('MACD')
        // 加载数据
        var chartDataList = kLineDataList.map(function (data) {
            return {
                timestamp: new Date(data[0]).getTime(),
                open: +data[1],
                high: +data[2],
                low: +data[3],
                close: +data[4],
                volume: Math.ceil(+data[5]),
            }
        })
        chart.applyNewData(chartDataList)
    }