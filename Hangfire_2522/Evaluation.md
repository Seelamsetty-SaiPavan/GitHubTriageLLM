# 🧪 LLM Evaluation – Hangfire Issue #2522

🔗 [GitHub Issue](https://github.com/HangfireIO/Hangfire/issues/2522)

---

## 🐛 Problem Summary

In Hangfire `v1.8.20`, a user reported that **19 million scheduled jobs** were due to run but were **not enqueued fast enough** despite having:

- 19 servers × 5 workers each
- `QueuePollInterval = 0` (maximum responsiveness)
- `UsePageLocksOnDequeue = true` (later removed)
- `MaxDegreeOfParallelismForSchedulers = 2`
- Hangfire SQL Server storage backend

This resulted in **severe delays** and a backlog of scheduled jobs.

---

## 🧠 LLM Prompt

> I'm using Hangfire with SQL Server and have 19 million scheduled jobs that are all due now, but they’re not enqueuing fast enough.  
> 
> Our setup: 19 servers, 5 workers each, using SqlServerStorage. Occasionally jobs burst into enqueue, then stall again.  
> 
> We’ve disabled `UsePageLocksOnDequeue` and set `QueuePollInterval = 0`.  
> 
> How can we make Hangfire enqueue these scheduled jobs faster?

---

## 🤖 LLM Response

ChatGPT recommended:

- Consider profiling performance using [`stdump`](https://github.com/HangfireIO/stdump)
- Review worker starvation or scheduler bottlenecks
- Tune `MaxDegreeOfParallelismForSchedulers`
- Add manual batching logic to enqueue jobs in parallel
- Monitor job transitions using Hangfire dashboard or logs
- Possibly switch to Redis if SQL Server is a bottleneck

---

## 🧪 Human Validation

### 🔧 Setup

- Simulated locally with **Hangfire.MemoryStorage**
- Scheduled 10,000 jobs using:

```csharp
for (int i = 0; i < 10000; i++)
{
    BackgroundJob.Schedule(() => Console.WriteLine($"Scheduled Job {i}"), TimeSpan.FromSeconds(30));
}
