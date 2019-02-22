class Yuri():
    """
    The main API methods that users of this class need to know are:
        step
        reset
        render
        reward
    And set the following attributes:
        action_space: The Space object corresponding to valid actions
        observation_space: The Space object corresponding to valid observations
    """
    
    #Meta data
    action_space = None
    observation_space = None
    done = False


    def reward(observation):
        """
        Args:
            observation (object): agent's observation of the current environment
        Returns:
            reward (float) : amount of reward returned after previous action
        """
        raise NotImplementedError

    def step(self, action):
        """Run one timestep of the game
        Accepts an action and returns a tuple (observation, reward, done).
        Args:
            action (enum): an action provided by the environment
        Returns:
            observation (object): agent's observation of the current environment
            reward (float) : amount of reward returned after previous action
            done (boolean): whether the episode has ended, in which case further step() calls will return undefined results
        """
        raise NotImplementedError

    def reset(self):
        """Resets the state of the environment and returns an initial observation.
        Returns: observation (object): the initial observation of the
            space.
        """
        raise NotImplementedError

    def render(self, mode='human'):
        """
        Args:
            mode='human' to play against the bot
        """
        raise NotImplementedError

