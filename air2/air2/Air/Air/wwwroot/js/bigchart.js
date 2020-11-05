bigchart = {

    initDashboardPageCharts: function (dataArr, labels) {

        gradientChartOptionsConfigurationWithTooltipBlue = {
            maintainAspectRatio: false,
            legend: {
                display: false
            },

            tooltips: {
                backgroundColor: '#f5f5f5',
                titleFontColor: '#333',
                bodyFontColor: '#666',
                bodySpacing: 4,
                xPadding: 12,
                mode: "nearest",
                intersect: 0,
                position: "nearest"
            },
            responsive: true,
            scales: {
                yAxes: [{
                    barPercentage: 1.6,
                    gridLines: {
                        drawBorder: false,
                        color: 'rgba(29,140,248,0.0)',
                        zeroLineColor: "transparent",
                    },
                    ticks: {
                        suggestedMin: 60,
                        suggestedMax: 125,
                        padding: 20,
                        fontColor: "#2380f7"
                    }
                }],

                xAxes: [{
                    barPercentage: 1.6,
                    gridLines: {
                        drawBorder: false,
                        color: 'rgba(29,140,248,0.1)',
                        zeroLineColor: "transparent",
                    },
                    ticks: {
                        padding: 20,
                        fontColor: "#2380f7"
                    }
                }]
            }
        };

        gradientChartOptionsConfigurationWithTooltipPurple = {
            maintainAspectRatio: false,
            legend: {
                display: false
            },

            tooltips: {
                backgroundColor: '#f5f5f5',
                titleFontColor: '#333',
                bodyFontColor: '#666',
                bodySpacing: 4,
                xPadding: 12,
                mode: "nearest",
                intersect: 0,
                position: "nearest"
            },
            responsive: true,
            scales: {
                yAxes: [{
                    barPercentage: 1.6,
                    gridLines: {
                        drawBorder: false,
                        color: 'rgba(29,140,248,0.0)',
                        zeroLineColor: "transparent",
                    },
                    ticks: {
                        suggestedMin: 60,
                        suggestedMax: 100,
                        padding: 20,
                        fontColor: "#9a9a9a"
                    }
                }],

                xAxes: [{
                    barPercentage: 1.6,
                    gridLines: {
                        drawBorder: false,
                        color: 'rgba(225,78,202,0.1)',
                        zeroLineColor: "transparent",
                    },
                    ticks: {
                        padding: 20,
                        fontColor: "#9a9a9a"
                    }
                }]
            }
        };

        gradientChartOptionsConfigurationWithTooltipOrange = {
            maintainAspectRatio: false,
            legend: {
                display: false
            },

            tooltips: {
                backgroundColor: '#f5f5f5',
                titleFontColor: '#333',
                bodyFontColor: '#666',
                bodySpacing: 4,
                xPadding: 12,
                mode: "nearest",
                intersect: 0,
                position: "nearest"
            },
            responsive: true,
            scales: {
                yAxes: [{
                    barPercentage: 1.6,
                    gridLines: {
                        drawBorder: false,
                        color: 'rgba(29,140,248,0.0)',
                        zeroLineColor: "transparent",
                    },
                    ticks: {
                        suggestedMin: 50,
                        suggestedMax: 110,
                        padding: 20,
                        fontColor: "#ff8a76"
                    }
                }],

                xAxes: [{
                    barPercentage: 1.6,
                    gridLines: {
                        drawBorder: false,
                        color: 'rgba(220,53,69,0.1)',
                        zeroLineColor: "transparent",
                    },
                    ticks: {
                        padding: 20,
                        fontColor: "#ff8a76"
                    }
                }]
            }
        };

        gradientChartOptionsConfigurationWithTooltipGreen = {
            maintainAspectRatio: false,
            legend: {
                display: false
            },

            tooltips: {
                backgroundColor: '#f5f5f5',
                titleFontColor: '#333',
                bodyFontColor: '#666',
                bodySpacing: 4,
                xPadding: 12,
                mode: "nearest",
                intersect: 0,
                position: "nearest"
            },
            responsive: true,
            scales: {
                yAxes: [{
                    barPercentage: 1.6,
                    gridLines: {
                        drawBorder: false,
                        color: 'rgba(29,140,248,0.0)',
                        zeroLineColor: "transparent",
                    },
                    ticks: {
                        suggestedMin: 50,
                        suggestedMax: 125,
                        padding: 20,
                        fontColor: "#9e9e9e"
                    }
                }],

                xAxes: [{
                    barPercentage: 1.6,
                    gridLines: {
                        drawBorder: false,
                        color: 'rgba(0,242,195,0.1)',
                        zeroLineColor: "transparent",
                    },
                    ticks: {
                        padding: 20,
                        fontColor: "#9e9e9e"
                    }
                }]
            }
        };


        gradientBarChartConfiguration = {
            maintainAspectRatio: false,
            legend: {
                display: false
            },

            tooltips: {
                backgroundColor: '#f5f5f5',
                titleFontColor: '#333',
                bodyFontColor: '#666',
                bodySpacing: 4,
                xPadding: 12,
                mode: "nearest",
                intersect: 0,
                position: "nearest"
            },
            responsive: true,
            scales: {
                yAxes: [{

                    gridLines: {
                        drawBorder: false,
                        color: 'rgba(29,140,248,0.1)',
                        zeroLineColor: "transparent",
                    },
                    ticks: {
                        suggestedMin: 60,
                        suggestedMax: 120,
                        padding: 20,
                        fontColor: "#9e9e9e"
                    }
                }],

                xAxes: [{

                    gridLines: {
                        drawBorder: false,
                        color: 'rgba(29,140,248,0.1)',
                        zeroLineColor: "transparent",
                    },
                    ticks: {
                        padding: 20,
                        fontColor: "#9e9e9e"
                    }
                }]
            }
        };


        var ctx = document.getElementById("chartBig1").getContext('2d');

        var gradientStroke = ctx.createLinearGradient(0, 230, 0, 50);

        gradientStroke.addColorStop(1, 'rgba(72,72,176,0.1)');
        gradientStroke.addColorStop(0.4, 'rgba(72,72,176,0.0)');
        gradientStroke.addColorStop(0, 'rgba(119,52,169,0)'); //purple colors
        var config = {
            type: 'line',
            data: {
                labels: labels,
                datasets: [{
                    label: "PM10",
                    fill: true,
                    backgroundColor: gradientStroke,
                    borderColor: '#d346b1',
                    borderWidth: 2,
                    borderDash: [],
                    borderDashOffset: 0.0,
                    pointBackgroundColor: '#d346b1',
                    pointBorderColor: 'rgba(255,255,255,0)',
                    pointHoverBackgroundColor: '#d346b1',
                    pointBorderWidth: 20,
                    pointHoverRadius: 4,
                    pointHoverBorderWidth: 15,
                    pointRadius: 4,
                    data: dataArr[0],
                },
                    {
                        label: "PM2.5",
                        fill: true,
                        backgroundColor: gradientStroke,
                        borderColor: 'rgba(29,140,248)',
                        borderWidth: 2,
                        borderDash: [],
                        borderDashOffset: 0.0,
                        pointBackgroundColor: 'rgba(29,140,248)',
                        pointBorderColor: 'rgba(255,255,255,0)',
                        pointHoverBackgroundColor: 'rgba(29,140,248)',
                        pointBorderWidth: 20,
                        pointHoverRadius: 4,
                        pointHoverBorderWidth: 15,
                        pointRadius: 4,
                        data: dataArr[1],
                    }]
            },
            options: gradientChartOptionsConfigurationWithTooltipPurple
        };


        var configPM10 = {
            type: 'line',
            data: {
                labels: labels,
                datasets: [{
                    label: "PM10",
                    fill: true,
                    backgroundColor: gradientStroke,
                    borderColor: '#d346b1',
                    borderWidth: 2,
                    borderDash: [],
                    borderDashOffset: 0.0,
                    pointBackgroundColor: '#d346b1',
                    pointBorderColor: 'rgba(255,255,255,0)',
                    pointHoverBackgroundColor: '#d346b1',
                    pointBorderWidth: 20,
                    pointHoverRadius: 4,
                    pointHoverBorderWidth: 15,
                    pointRadius: 4,
                    data: dataArr[0],
                }]
            },
            options: gradientChartOptionsConfigurationWithTooltipPurple
        };

        var configPM25 = {
            type: 'line',
            data: {
                labels: labels,
                datasets: [{
                    label: "PM2.5",
                    fill: true,
                    backgroundColor: gradientStroke,
                    borderColor: 'rgba(29,140,248)',
                    borderWidth: 2,
                    borderDash: [],
                    borderDashOffset: 0.0,
                    pointBackgroundColor: 'rgba(29,140,248)',
                    pointBorderColor: 'rgba(255,255,255,0)',
                    pointHoverBackgroundColor: 'rgba(29,140,248)',
                    pointBorderWidth: 20,
                    pointHoverRadius: 4,
                    pointHoverBorderWidth: 15,
                    pointRadius: 4,
                    data: dataArr[1],
                }]
            },
            options: gradientChartOptionsConfigurationWithTooltipPurple
        };

        var myChartData = new Chart(ctx, config);
        var myChartDataPM10 = new Chart(ctx, configPM10);
        var myChartDataPM25 = new Chart(ctx, configPM25);
        $("#0").click(function () {
            var chart_data1 = dataArr[0];
            var chart_data2 = dataArr[1];
            var data = myChartData.config.data;
            data.datasets[0].data = chart_data1;
            data.datasets[1].data = chart_data2;
            data.labels = labels;
            myChartData.update();
        });
        $("#1").click(function () {
            var chart_data1 = dataArr[0];
            var data = myChartDataPM10.config.data;
            data.datasets[0].data = chart_data1;
            data.labels = labels;
            myChartDataPM10.update();
        });
        $("#2").click(function () {
            var chart_data2 = dataArr[1];
            var data = myChartDataPM25.config.data;
            data.datasets[0].data = chart_data2;
            data.labels = labels;
            myChartDataPM25.update();
        });

       


    }

}