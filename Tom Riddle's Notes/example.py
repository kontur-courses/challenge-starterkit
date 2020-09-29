from API import Client, TaskStatus, Task

team_secret = ""
challenge_id = "projects-course"

client = Client(team_secret, challenge_id=challenge_id)

def solve(task: Task) -> str:
    return "42"

task_type = "starter"
task = client.fetch_new_task(task_type)
answer = solve(task)

status = client.submit_answer(task.id, answer).status
if status != TaskStatus.Success:
    print("failed")
else:
    print("solved")
