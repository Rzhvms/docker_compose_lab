const express = require('express');
const path = require('path');
const app = express();
const PORT = 80;

// Сервируем статические файлы
app.use(express.static(path.join(__dirname)));

// Запуск сервера
app.listen(PORT, () => {
  console.log(`Frontend running on http://localhost:${PORT}`);
});