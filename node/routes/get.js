module.exports = function(webservice) {
  
  
  const express = require('express');
  const router = express.Router();
  
  router.get('/', function(req, res, next) {
    
    
    const cb = function(refuellist) {
      res.render('refuels', {refuels:refuellist});
    };
    
    webservice.getAllRefuels(cb);
  });
  
  return router;
};
