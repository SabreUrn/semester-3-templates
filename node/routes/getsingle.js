module.exports = function(webservice) {
  
  
    const express = require('express');
    const router = express.Router();
    
    router.get('/', function(req, res, next) {
      let id = req.query.id;
      console.log(req.query.id);
      
      const cb = function(refuellist) {
        res.render('refuels', {refuels:refuellist});
      };
      
      webservice.getOneCustomerRefuel(id, cb);
    });
    
    return router;
  };
  