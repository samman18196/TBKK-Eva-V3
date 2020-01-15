// Set new default font family and font color to mimic Bootstrap's default styling
Chart.defaults.global.defaultFontFamily = '-apple-system,system-ui,BlinkMacSystemFont,"Segoe UI",Roboto,"Helvetica Neue",Arial,sans-serif';
Chart.defaults.global.defaultFontColor = '#292b2c';



var ctx = document.getElementById("myDoughnutChart");
var myDoughnutChart = new Chart(ctx, {
    type: 'doughnut',
    data: data = {
        datasets: [{
            data: [10, 20, 30],
            backgroundColor: ['#007bff', '#dc3545', '#ffc107', ],
        }],
        labels: [
            'Red',
            'Yellow',
            'Blue'
        ]
    },
    
});