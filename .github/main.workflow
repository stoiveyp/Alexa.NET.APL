workflow "New workflow" {
  on = "release"
  resolves = ["Do Nothing"]
}

action "Do Nothing" {
  uses = "stoiveyp/CustomGithub@Test"
}
