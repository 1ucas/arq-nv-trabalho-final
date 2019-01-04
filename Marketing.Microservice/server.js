'use strict';

const express = require('express');

// Constants
const PORT = 9096;
const HOST = '0.0.0.0';

// App
const app = express();
app.get('/privacidade', (req, res) => {
  res.send('<h1>Política de Privacidade</h1><h4>Os dados dos usuários não serão compartilhados com terceiros.</h4>');
});

app.get('/termos', (req, res) => {
  res.send('<h1>Termos de Uso</h1><h4>Como usuário é seu dever fazer bom uso da aplicação.</h4>');
});

app.listen(PORT, HOST);
console.log(`Running on http://${HOST}:${PORT}`);