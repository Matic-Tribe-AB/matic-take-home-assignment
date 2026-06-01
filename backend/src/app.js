const express = require('express');
const cors = require('cors');

const app = express();
const PORT = process.env.PORT || 3001;

app.use(cors());
app.use(express.json());

// -------------------------------------------------------
// TODO: Implement your data store here
// (in-memory, JSON file, SQLite — your choice)
// -------------------------------------------------------

// -------------------------------------------------------
// TODO: Implement these routes
//
// GET    /api/posts        → return all posts, newest first
// POST   /api/posts        → create a post { title, body }
// PATCH  /api/posts/:id    → toggle read status
// DELETE /api/posts/:id    → delete a post
// -------------------------------------------------------

app.get('/api/health', (req, res) => {
  res.json({ status: 'ok' });
});

app.listen(PORT, () => {
  console.log(`PostFeed API running on http://localhost:${PORT}`);
});

module.exports = app;
