# 🤖 GitHub LLM Evaluation – Real-World Issue Validation

This repository contains hands-on validation of Large Language Model (LLM)-generated software solutions against real-world GitHub issues from high-quality open-source projects.

> Focused on bug triaging, code reproduction, AI validation, and documenting results to support LLM training.

---

## ✅ Completed Evaluations

| Repository   | Issue    | Description                                         | Status   |
|--------------|----------|-----------------------------------------------------|----------|
| AutoMapper   | #4542    | Constructor removed – `MapperConfiguration(...)`    | ✅ Done  |
| Hangfire     | #2522    | Scheduled jobs not being enqueued under load        | ✅ Done  |
| Serilog      | #2176    | Logging throws `ObjectDisposedException`            | ✅ Done  |

Each issue includes:
- A **reproduction project** (in `/BugDemo`)
- The original **LLM prompt**
- The **LLM response**
- A human-in-the-loop **evaluation report** (`Evaluation.md`)

---

## 🧠 Why This Matters

This project simulates the role of an **LLM validation engineer**:
- Evaluate how LLMs handle real bugs and migration challenges
- Verify output accuracy, usefulness, and completeness
- Provide human-grounded feedback to help train smarter models

---

## 📂 Repository Structure

GitHubTriageLLM/
├── AutoMapper_4542/
│   ├── BugDemo/           - Reproduction code
│   └── Evaluation.md      - LLM prompt, response, verdict

├── Hangfire_2522/
│   ├── BugDemo/
│   └── Evaluation.md

├── Serilog_2176/
│   ├── BugDemo/
│   └── Evaluation.md

└── README.md              - Project overview and issue index
---

## 👨‍💻 Author

**Saipavan Seelamsetty**  
🔗 [GitHub Profile](https://github.com/Seelamsetty-SaiPavan)

---

## 🛠️ Tools Used

- C# (.NET 8 Console Applications)
- GitHub Issue Triage
- Open-source projects: AutoMapper, Hangfire, Serilog
- ChatGPT (LLM) Prompting and Output Evaluation
- Markdown-based documentation

---

## 📌 Role Relevance

This repository demonstrates readiness for:

- ✅ LLM Evaluation Engineer
- ✅ AI Prompt Engineer
- ✅ Software QA & Automation Analyst
- ✅ Developer in AI/ML Human Feedback Loops

---
