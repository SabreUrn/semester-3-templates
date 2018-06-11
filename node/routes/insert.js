module.exports = function(webservice) {
  
  
    const express = require('express');
    const router = express.Router();
    
    // router.get('/', function(req, res, next) {
      
      
    //   const cb = function(refuellist) {
    //     res.render('postrefuel', {refuels:refuellist});
    //   };
      
    //   webservice.getAllRefuels(cb);
    // });

    router.post('/', function(req, res) {
        const cb = function(ok) {
            if(ok) {
                res.sendStatus(200);
            } else {
                res.sendStatus(500);
            }
            res.end();
        };
        webservice.addRefuel(req.body.unikid, req.body.kundenr, req.body.antalliter, cb);
    });
    
    return router;
  };
  