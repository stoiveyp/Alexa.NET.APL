workflow "New workflow" {
  on = "push"
  resolves = ["Do Nothing"]
}

action "Do Nothing" {
  uses = "stoiveyp/CustomGithub@Test"
}
