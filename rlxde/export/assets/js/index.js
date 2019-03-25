clippy.load('Clippy', function (agent) {
  const animations = agent.animations();
  $('.js-states').text(animations.join(' '));
  agent.show();
  agent.moveTo(100, 100);
  agent.speak('Are you having trouble signing up there?.');
  setTimeout(animate.bind(null, agent, animations), 8000);
});

function animate(agent, animations) {

  function doneCallback(animation) {
    console.log('done ' + animation);
  }

  let statesText = animations.join(' '),
  $state = $('.js-state'),
  $states = $('.js-states');

  for (var i = 0; i < animations.length; i++) {
    (index => {
      setTimeout(_ => {
        let animation = animations[index];
        let currentStateInStates = statesText.replace(animation, `<b>${animation}</b>`);
        $state.text(animation);
        $states.html(currentStateInStates);
        agent.play(animation, undefined, doneCallback.bind(null, animation));
      }, index * 8000);
    })(i);
  }
}