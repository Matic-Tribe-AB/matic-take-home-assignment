# PostFeed – Work Sample

**Estimated time:** 2–4 hours  
**Role:** Developer / Solution Architect (mid-level, full-stack)

---

## Overview

You are building **PostFeed** — a minimal full-stack app where users can post short updates (like a private internal feed), mark them as read, and delete them.

This exercise has three parts. Complete them in order. All three parts matter — Part 2 and 3 are not optional.

> **AI tools are allowed and encouraged.** We expect you to use them. Part 3 is where you tell us how.

---

## The Task

### Part 1 — Build it (~2 hours)

Implement the following using the starter scaffolding in this repo:

**Backend (.NET 10 / ASP.NET Core)**

| Method | Path | Description |
|--------|------|-------------|
| `GET` | `/api/posts` | Return all posts, newest first |
| `POST` | `/api/posts` | Create a post (`title`, `body`) |
| `PATCH` | `/api/posts/{id}` | Toggle `read` status on a post |
| `DELETE` | `/api/posts/{id}` | Delete a post |

Persistence is your choice: in-memory, JSON file, or SQLite. State your choice in your design doc.

**Frontend (React + Vite)**

- Display the list of posts (title, body, read/unread status, timestamp)
- Form to create a new post
- Button to toggle read/unread on each post
- Button to delete a post
- Handle loading and error states

**Requirements**

- Backend and frontend must run independently (separate ports, CORS handled)
- At least one test — backend or frontend, your choice of framework
- Backend must run with `dotnet run --project PostFeed.Api` from the `backend/` folder

---

### Part 2 — Design it (~1 hour)

Create a file `DESIGN.md` in the repo root. Answer these four questions. Total length: 1–2 pages.

1. **Production-readiness** — What would you add or change to make this production-ready? (auth, config management, deployment, observability)

2. **Scale** — How would you redesign the data layer and API if this needed to handle 50,000 concurrent users?

3. **New feature: scheduled digest** — A stakeholder wants users to receive a daily email digest of unread posts. How would you implement this? Describe the components, data flow, and any third-party services.

4. **Biggest risk** — What is the single biggest technical risk in your implementation, and how would you address it?

---

### Part 3 — Reflect on your AI usage (~15–30 min)

Create a file `AI_LOG.md` in the repo root. We want to understand how you work with AI tools.

Answer these questions:

1. **Which tools did you use?** (e.g. Claude, GitHub Copilot, ChatGPT, Cursor, etc.)

2. **For each significant use:** What did you ask for / what was your prompt intent? What did you get back? What did you accept, modify, or discard?

3. **What took longest without AI?** What would have taken the most time if you hadn't used AI?

4. **Where did AI get it wrong?** Describe at least one case where AI output needed correction, and what you changed.

There are no wrong answers here — we are evaluating your judgment and transparency, not whether you used AI or not.

---

## Repo Structure

```
matic-take-home-assignment/
├── backend/
│   ├── PostFeed.Api/
│   │   └── Program.cs     # ASP.NET Core entry point (starter)
│   ├── PostFeed.Tests/
│   │   └── HealthTests.cs # Integration test example
│   ├── PostFeed.slnx
│   └── README.md
├── frontend/
│   ├── src/
│   │   ├── main.jsx       # React entry point (starter)
│   │   └── App.jsx        # App shell (starter)
│   ├── index.html
│   ├── vite.config.js
│   └── package.json
├── DESIGN.md              # ← You create this (Part 2)
├── AI_LOG.md              # ← You create this (Part 3)
└── README.md              # This file
```

---

## Getting Started

### 1. Clone this repo

You will receive a link to your own private copy of this repo. Clone it:

```bash
git clone <your-repo-url>
cd matic-take-home-assignment
```

### 2. Run the backend

```bash
cd backend
dotnet run --project PostFeed.Api
# Runs on http://localhost:3001
```

### 3. Run the frontend

```bash
cd frontend
npm install
npm run dev
# Runs on http://localhost:5173
```

---

## Submitting Your Work

When you are done (or when time is up):

1. Make sure all your work is committed and pushed
2. Ensure `DESIGN.md` and `AI_LOG.md` exist in the root
3. Reply to our email to let us know you're done — we'll review the repo directly

**Time limit:** Please do not spend more than 4 hours. If you run out of time, commit what you have and note in `AI_LOG.md` what you would have done next.

---

## Evaluation Criteria

We assess your submission across four areas:

| Area | What we look at |
|------|----------------|
| **Implementation** | Do the endpoints and UI features work? Is persistence handled? Are edge cases covered? |
| **Code quality** | Structure, readability, error handling, test coverage |
| **Architecture thinking** | Depth and practicality of your DESIGN.md answers |
| **AI collaboration** | Do you use AI to amplify your output? Can you explain and own the result? |

---

*Questions? Email us before you start, not during.*
