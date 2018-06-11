const url = require('url');
const http = require('http');

class WebserviceClient {
    constructor(serviceURL) {
        this.serviceURL = new url.URL(serviceURL);
    }

    getAllRefuels(callback) {
        const options = {
            method: 'GET',
            hostname: this.serviceURL.hostname,
            port: this.serviceURL.port,
            path: this.serviceURL + '/optankning/'
            // headers: { "content-type": "application/json" }
        };
        console.log('serviceURL: ' + options.path);
        const req = http.request(options, function(res) {
            let body = '';
            res.on('data', function(chunk) {
                body += chunk.toString();
            });

            res.on('end', function() {
                console.log(res.statusCode);
                callback(JSON.parse(body));
            });
        });
        
        req.end();
    }

    getOneCustomerRefuel(id, callback) {
        const options = {
            method: 'GET',
            hostname: this.serviceURL.hostname,
            port: this.serviceURL.port,
            path: this.serviceURL + `/optankning?id=${id}`
            // headers: { "content-type": "application/json" }
        };
        console.log('serviceURL: ' + options.path);
        const req = http.request(options, function(res) {
            let body = '';
            res.on('data', function(chunk) {
                body += chunk.toString();
            });

            res.on('end', function() {
                console.log(res.statusCode);
                callback(JSON.parse(body));
            });
        });
        
        req.end();
    }

    addRefuel(unikid, kundenr, antalliter, callback) {
        const options = {
            method: 'POST',
            host: this.serviceURL.hostname,
            port: this.serviceURL.port,
            path: this.serviceURL.pathname + '/optankning/',
            headers: { 'content-type': 'application/json' }
        };
        const req = http.request(options, function(res) {
            callback(res.statusCode === 200);

        });
        req.write(JSON.stringify({
            UnikId: unikid,
            KundeNr: kundenr,
            AntalLiter: antalliter
        }));
        req.end();
    }
}

module.exports = WebserviceClient;