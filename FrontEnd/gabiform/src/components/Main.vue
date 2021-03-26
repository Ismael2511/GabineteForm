<template>
    <div>
        <Header /> 
        <Form /> 
    </div>
</template>

<script>
import Header from './Header'
import Form from './Form'
export default ({
    name:'Main',
    components: {
        Header,
        Form
    }
})
</script>
